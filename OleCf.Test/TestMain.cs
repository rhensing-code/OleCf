﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace OleCf.Test
{
    [TestFixture]
    public class TestMain
    {
        public static string BasePath = @"..\..\TestFiles";
        public static string Win10Path = Path.Combine(BasePath, "Win10");
        public static string Win2K3Path = Path.Combine(BasePath, "Win2k3");
        public static string Win7Path = Path.Combine(BasePath, "Win7");
        public static string Win80Path = Path.Combine(BasePath, "Win80");
        public static string Win81Path = Path.Combine(BasePath, "Win81");
        public static string Win2012Path = Path.Combine(BasePath, "Win2012");
        public static string Win2012R2Path = Path.Combine(BasePath, "Win2012R2");

        public static string MiscPath = Path.Combine(BasePath, "Misc");
        public static string BadPath = Path.Combine(BasePath, "Bad");

        private readonly List<string> _allPaths = new List<string>
        {
            //MiscPath,
            //WinXpPath,
            Win10Path,
            //Win2K3Path,
            Win7Path,
            Win80Path,
            Win81Path
            //Win2012Path,
            //Win2012R2Path,
        };


        [Test]
        public void BaseTests()
        {
            var names = new List<string>();

            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\f01b4d95cf55d32a.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\9fda41b86ddcf1db.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\f01b4d95cf55d32a.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\16d71406474462b5.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\ecf56f5453131993.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\5d696d521de238c3.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\9b9ddaa5d843df22.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\19e6043495a5b4da.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\fb3b0dbfee58fac8.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\a52b0784bd667468.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\b8ab77100df80ab2.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\b08971c77377bde3.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\5bb830f67194431a.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\7e4dca80246863e3.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\8b42b97066bc0061.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\b7173093b23b9a6a.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\1bc392b8e104a00e.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\b842d0b8aaf85331.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\1b4dd67f29cb1962.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\ab59ac921dd5279b.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\ed3d6a1919d189ef.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\9b9cdc69c1c24e2b.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\12dc1ea8e34b5a6.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\28c8b86deab549a1.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\31bf0a48aa42a204.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\fe57f5df17b45fe.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\ffffffffffffffff.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\2f114339dfde05dc.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\3adcb4f967a06797.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\3f037929be9d678b.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\9d19c3b6cd6f3895.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\10e5cc431e1ddebf.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\74ea779831912e30.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\711dad2719bb5b05.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\3899c1cd9ece8edc.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\6199ce2e26f4bd1f.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\dbaa0d4551328cf9.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\e10efea2aa965a4d.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\e42c745f50f3ad9a.automaticDestinations-ms");
            //            names.Add(
            //                @"C:\Users\e\AppData\Roaming\Microsoft\Windows\Recent\AutomaticDestinations\f775121a7552cce7.automaticDestinations-ms");
            //            

            foreach (var allPath in _allPaths)
            {
                foreach (var fname in Directory.GetFiles(allPath))
                {
                    Debug.WriteLine(fname);
                    var o = OleCf.LoadFile(fname);

                    o.Header.Should().NotBeNull();

                    Debug.WriteLine(o.Header);

                    o.DestList?.Entries.Count.Should().Be(o.DestList.Header.NumberOfEntries);

                    Debug.WriteLine($"Directory items. total: {o.DirectoryItems.Count}");
                    foreach (var directoryItem in o.DirectoryItems)
                    {
                        if (directoryItem.DirectoryName.ToLowerInvariant() == "root entry")
                        {
                            continue;
                        }

                        Debug.WriteLine($"Name: {directoryItem.DirectoryName}, Size: {directoryItem.DirectorySize}");

                        if (directoryItem.DirectorySize > 0)
                        {
                            var p = o.GetPayloadForDirectory(directoryItem);


                            var ddd = Path.GetFileNameWithoutExtension(fname);
                            var basePath = Path.Combine(@"C:\temp", ddd);
                            if (Directory.Exists(basePath))
                            {
                                try
                                {
                                    Directory.Delete(basePath);
                                }
                                catch (Exception)
                                {
                                }
                            }

                            Directory.CreateDirectory(basePath);

                            var rf = Path.Combine(@"C:\temp\", basePath, directoryItem.DirectoryName + ".lnk.test");

//
//                    if (p[0] == 0x4c)
//                    {
//                        File.WriteAllBytes(rf, p);
//                    }
//                    else
//                    {
//                        rf = Path.Combine(@"C:\temp\", basePath, directoryItem.DirectoryName + ".test");
//                        File.WriteAllBytes(rf, p);
//                    }
                        }
                    }

                    if (o.DestList != null)
                    {
                        Debug.WriteLine(
                            $"\r\nDestLists. Total entries: {o.DestList.Entries.Count}, Header entry count: {o.DestList.Header.NumberOfEntries}");
                        foreach (var destListEntry in o.DestList.Entries)
                        {
                            Debug.WriteLine(destListEntry);

                            var dlnk =
                                o.DirectoryItems.SingleOrDefault(
                                    t => t.DirectoryName == destListEntry.EntryNumber.ToString("X"));

                            if (dlnk != null)
                            {
                                Debug.WriteLine($"Found directory entry: {dlnk}");

                                var dlnkB = o.GetPayloadForDirectory(dlnk);

                                if (dlnkB[0] == 0x4c)
                                {
                                    Debug.WriteLine("Ya, its a lnk file\r\n");
                                }
                                else
                                {
                                    Debug.WriteLine("Nooooo");
                                }
                            }
                        }
                    }
                }
            }
        }

        [Test]
        public void InvalidFileShouldThrowException()
        {
            var badFile = Path.Combine(BadPath, @"CALC.EXE-3FBEF7FD.pf");
            Action action = () => OleCf.LoadFile(badFile);

            action.ShouldThrow<Exception>().WithMessage("Invalid signature!");
        }
    }
}