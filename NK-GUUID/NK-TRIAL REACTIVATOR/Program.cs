      //===========================================\\
     //#############################################\\
    //#################  BY N0RMIE ##################\\
   //######### https://github.com/N0rmie #############\\
  //###################################################\\
 //###########    THIS IS FREE DON´T SKID    ###########\\
//=======================================================\\



using Microsoft.Win32; //Imports
using Microsoft.Win32.SafeHandles;//Imports
using System;//Imports
using System.Collections.Generic;//Imports
using System.Globalization;//Imports
using System.IO;//Imports
using System.Linq;//Imports
using System.Runtime.InteropServices;//Imports
using System.Security.Principal;//Imports
using System.Threading;//Imports
using static System.Net.Mime.MediaTypeNames;//Imports

namespace NK_TRIAL_REACTIVATOR
{
    class Program
    {
        public static void SpoofGUID() //Spoofer Itself For MachineGuid
        {

            string guid = Guid.NewGuid().ToString();

            RegistryKey OurKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);//Open RegistryKey
            OurKey = OurKey.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", true);//MachineGuid Location
            string result = (string)OurKey.GetValue("MachineGuid"); //Get Value for MachineGuid
            System.IO.File.WriteAllText(@"C:\NK-GUID Logs2.txt", "### MADE BY NK-PROJECT - GUUID SPOOFER       Old MachineGuid: " + result + "   New: " + guid);//Save Logs for MachineGuid
            OurKey.SetValue("MachineGuid", guid);//Set Value for MachineGuid
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"{<\NK/>} Old MachineGuid: " + result + "   New: " + guid);
            OurKey.Close();//Close RegistryKey


        }






        public static void SpoofHwProfileGUID()//Spoofer Itself For HwProfileGUID
        {
            string hwguid = "{" + Guid.NewGuid().ToString() + "}"; //Necessary

            RegistryKey OurKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);//Open RegistryKey
            OurKey = OurKey.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001", true);//HwProfileGUID Location
            string result = (string)OurKey.GetValue("HwProfileGUID"); //Get Value for HwProfileGUID
            System.IO.File.WriteAllText(@"C:\NK-GUID Logs.txt", "### MADE BY NK-PROJECT - GUUID SPOOFER       Old HwProfileGUID: " + result + "   New: " + hwguid);//Save Logs for HwProfileGUID
            OurKey.SetValue("HwProfileGUID", hwguid);//Set Value for HwProfileGUID
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"{<\NK/>} Old HwProfileGUID: " + result + "   New: " + hwguid);
            OurKey.Close();//Close RegistryKey


        }


        static void Main(string[] args)
        { 
            Console.Title = "NK-TRIAL REACTIVATOR";//Console Title
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"######## 6 ###########");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"######### 6 ##########");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"########## 6 #########");
            Thread.Sleep(2000);
            
            N0rmieCheck: //Errors Checkpoint

            Console.Title = "NK-TRIAL REACTIVATOR";//Console Title
            if (IsAdmin()) //Is Admin? if Yes:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"{<\NK/>} Thanks For Choosing Us...");//Junk
                Console.WriteLine(@"{<\NK/>} Initializing...");//Junk
                Thread.Sleep(2500);//Junk
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(@"

    _   ____ __      ____  ____  ____      ____________________
   / | / / //_/     / __ \/ __ \/ __ \    / / ____/ ____/_  __/
  /  |/ / ,< ______/ /_/ / /_/ / / / /_  / / __/ / /     / /   
 / /|  / /| /_____/ ____/ _, _/ /_/ / /_/ / /___/ /___  / /    
/_/ |_/_/ |_|    /_/   /_/ |_|\____/\____/_____/\____/ /_/  ");//Junk
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine(@"   
                        ╔═╗╦ ╦╦╔╦╗  ╔╦╗╦═╗╦╔═╗╦    ╔═╗╔═╗╔╦╗╦╦  ╦╔═╗╔╦╗╔═╗╦═╗
                        ║ ╦║ ║║ ║║   ║ ╠╦╝║╠═╣║    ╠═╣║   ║ ║╚╗╔╝╠═╣ ║ ║ ║╠╦╝
                        ╚═╝╚═╝╩═╩╝   ╩ ╩╚═╩╩ ╩╩═╝  ╩ ╩╚═╝ ╩ ╩ ╚╝ ╩ ╩ ╩ ╚═╝╩╚═ -- GUID Changer To Reactivate Freeware
");//Junk
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(@"{<\NK/>} Do You Want To Spoof Guid To Reactivate Trials? [Y/N] "); //Choose if Spoof
                Console.ForegroundColor = ConsoleColor.Red;
                string pncopt = Console.ReadLine();

                if (pncopt == "Y")//Want To Spoof? if Yes:
                {
                    Console.WriteLine(@"{<\NK/>} Spoofing..."); //Junk
                    Thread.Sleep(500);//Junk
                    Console.WriteLine(@"{<\NK/>} Changing GUID...");//Junk
                    Console.WriteLine(@"{<\NK/>} Spoofing Serials...



");//Junk
                    try //Try Spoofing
                    {
                        SpoofHwProfileGUID(); //Spoof HwProfileGUID
                        SpoofGUID();//Spoof MachineGUID
                    }
                    catch //If Error Go Checkpoint
                    {
                        goto N0rmieCheck;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"


{<\NK/>} Succes!!!
{<\NK/>} Remember To Purcharse Official Licenses, This Only For Educational Porpouses...


"); //Yeah remember to do that
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(@"{<\NK/>} Do You Want To Open Credits? [Y/N] "); //Credits (Pls do not touch <3)
                    string pncopt2 = Console.ReadLine();//Surprise
                    if(pncopt2 == "Y") //Surprise
                    {
                        Console.Write(@"{<\NK/>} Made By NK-PROJECT (GHH/N0rmie) ");//Surprise
                        System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=iik25wqIuFo");//Surprise
                        Console.ReadLine();//Surprise
                    }
                    else
                    {
                        Environment.Exit(666);//Exit
                    }

                }
                else if (pncopt == "N")//Want To Spoof? if No:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"

{<\NK/>} Closing, Wait 2 Sec...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);//Exit
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"

{<\NK/>} Invalid Option Selected...
{<\NK/>} Restarting, Wait 2 Sec...");
                    Thread.Sleep(2000);
                    goto N0rmieCheck;//Go to Error Checkpoint

                }
            }
            else //Is Admin? if No:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"{<\NK/>} Need To Run As Admin...
{<\NK/>} Closing, Wait 2 Sec...");
                Thread.Sleep(2000);
                Environment.Exit(0); //Exit
            }
            bool IsAdmin()//Checks Admin (Thx to StackOverFlow xD)
            {//Checks Admin (Thx to StackOverFlow xD)
                return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator); //Checks Admin (Thx to StackOverFlow xD)
            }//Checks Admin (Thx to StackOverFlow xD)
        }
    }
}

