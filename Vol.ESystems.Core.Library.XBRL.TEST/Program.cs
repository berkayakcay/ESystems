using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Vol.ESystems.Core.Library.XBRL.Base;
using Vol.ESystems.Core.Library.XBRL.Model;
using Reference = System.Security.Cryptography.Xml.Reference;


namespace Vol.ESystems.Core.Library.XBRL.TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            test:

            GetYevmiye();

            goto test;
        }

        private static void GetYevmiye()
        {
            Defter defter = new Defter()
            {
                Xbrl = new Xbrl()
                {
                    SchemaRef = new SchemaRef()
                    {
                        Href = "../xsd/2006-10-25/plt/case-c-b/gl-plt-2006-10-25.xsd",
                        Type = "simple"
                    },
                    Context = new Context()
                    {
                        Id = "journal_context",
                        Entity = new Entity()
                        {
                            Identifier = new Identifier()
                            {
                                Scheme = "http://www.gib.gov.tr",
                                Text = "1234567808"
                            }
                        },
                        Period = new Period()
                        {
                            Instant = "2017-02-01"
                        }
                    },
                    Unit = new List<Unit>()
                    {
                        new Unit()
                        {
                            Id = "try",
                            Measure= "iso4217:TRY"
                        },
                        new Unit()
                        {
                            Id = "countable",
                            Measure= "xbrli:pure"
                        }
                    },
                    AccountingEntries = new AccountingEntries()
                    {
                        DocumentInfo = new DocumentInfo()
                        {
                            EntriesType = new EntriesType()
                            {
                                ContextRef = "journal_context",
                                Text = "journal"
                            },
                            UniqueID = new UniqueID()
                            {
                                ContextRef = "journal_context",
                                Text = "YEV201701000001"
                            },
                            Language = new Language()
                            {
                                ContextRef = "journal_context",
                                Text = "iso639:tr"
                            },
                            CreationDate = new CreationDate()
                            {
                                ContextRef = "journal_context",
                                Text = "2017-02-01"
                            },
                            Creator = new Creator()
                            {
                                ContextRef = "journal_context",
                                Text = "Berkay AKÇAY"
                            },
                            EntriesComment = new EntriesComment()
                            {
                                ContextRef = "journal_context",
                                Text = "1 Ocak 2017 - 31 Ocak 2017 arası VOLANT YAZILIM Anonim Şirketine ait yevmiye defteri"
                            },
                            PeriodCoveredStart = new PeriodCoveredStart()
                            {
                                ContextRef = "journal_context",
                                Text = "2017-01-01"
                            },
                            PeriodCoveredEnd = new PeriodCoveredEnd()
                            {
                                ContextRef = "journal_context",
                                Text = "2017-01-31"
                            },
                            SourceApplication = new SourceApplication()
                            {
                                ContextRef = "journal_context",
                                Text = "1234567808##Gelir İdaresi Başkanlığı##VOLANT e-Defter Uygulaması##1.0.0.1"
                            }

                        },
                        EntityInformation = new EntityInformation()
                        {
                            EntityPhoneNumber = new EntityPhoneNumber()
                            {
                                PhoneNumberDescription = new PhoneNumberDescription()
                                {
                                    ContextRef = "journal_context",
                                    Text = "main"
                                },
                                PhoneNumber = new PhoneNumber()
                                {
                                    ContextRef = "journal_context",
                                    Text = "02121111111"
                                }
                            },
                            EntityFaxNumberStructure = new EntityFaxNumberStructure()
                            {
                                EntityFaxNumber = new EntityFaxNumber()
                                {
                                    ContextRef = "journal_context",
                                    Text = "02121111112"
                                }
                            },
                            EntityEmailAddressStructure = new EntityEmailAddressStructure()
                            {
                                EntityEmailAddress = new EntityEmailAddress()
                                {
                                    ContextRef = "journal_context",
                                    Text = "destek@volantyazilim.com.tr"
                                }
                            },
                            OrganizationIdentifiers = new OrganizationIdentifiers()
                            {
                                OrganizationIdentifier = new OrganizationIdentifier()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Volant Anonim Şirketi"
                                },
                                OrganizationDescription = new OrganizationDescription()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Kurum Unvanı"
                                }
                            },
                            OrganizationAddress = new OrganizationAddress()
                            {
                                OrganizationBuildingNumber = new OrganizationBuildingNumber()
                                {
                                    ContextRef = "journal_context",
                                    Text = "26/4"
                                },
                                OrganizationAddressStreet = new OrganizationAddressStreet()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Atatürk Caddesi"
                                },
                                OrganizationAddressStreet2 = new OrganizationAddressStreet2()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Gümüş Sokak"
                                },
                                OrganizationAddressCity = new OrganizationAddressCity()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Ankara"
                                },
                                OrganizationAddressZipOrPostalCode = new OrganizationAddressZipOrPostalCode()
                                {
                                    ContextRef = "journal_context",
                                    Text = "06110"
                                },
                                OrganizationAddressCountry = new OrganizationAddressCountry()
                                {
                                    ContextRef = "journal_context",
                                    Text = "Türkiye"
                                }
                            },
                            EntityWebSite = new EntityWebSite()
                            {
                                WebSiteURL = new WebSiteURL()
                                {
                                    ContextRef = "journal_context",
                                    Text = "www.volantyazilim.com.tr"
                                }
                            },
                            BusinessDescription = new BusinessDescription()
                            {
                                ContextRef = "journal_context",
                                Text = "19.84.1.1.00"
                            },
                            FiscalYearStart = new FiscalYearStart()
                            {
                                ContextRef = "journal_context",
                                Text = "2017-01-01"
                            },
                            FiscalYearEnd = new FiscalYearEnd()
                            {
                                ContextRef = "journal_context",
                                Text = "2017-12-31"
                            },
                            AccountantInformation = new List<AccountantInformation>()
                            {
                                new AccountantInformation()
                                {
                                    AccountantName = new AccountantName()
                                    {
                                        ContextRef = "journal_context",
                                        Text = "SMM Ali Can"
                                    },
                                    AccountantAddress = new AccountantAddress()
                                    {
                                        AccountantBuildingNumber = new AccountantBuildingNumber()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "26/4"
                                        },
                                        AccountantStreet = new AccountantStreet()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "Atatürk Caddesi"
                                        },
                                        AccountantAddressStreet2 = new AccountantAddressStreet2()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "Gümüş Sokak"
                                        },
                                        AccountantCity = new AccountantCity()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "Ankara"
                                        },
                                        AccountantZipOrPostalCode = new AccountantZipOrPostalCode()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "06110"
                                        },
                                        AccountantCountry = new AccountantCountry()
                                        {
                                            ContextRef = "journal_context",
                                            Text = "Türkiye"
                                        }
                                    },
                                    AccountantEngagementTypeDescription = new AccountantEngagementTypeDescription()
                                    {
                                        ContextRef = "journal_context",
                                        Text = "YMM sözleşmesi, 2016-01-01, M10121"
                                    },
                                    AccountantContactInformation = new AccountantContactInformation()
                                    {
                                        AccountantContactPhone = new AccountantContactPhone()
                                        {
                                            AccountantContactPhoneNumberDescription = new AccountantContactPhoneNumberDescription()
                                            {
                                                ContextRef = "journal_context",
                                                Text = "bookkeeper"
                                            },
                                            AccountantContactPhoneNumber = new AccountantContactPhoneNumber()
                                            {
                                                ContextRef = "journal_context",
                                                Text = "02122222224"
                                            }
                                        },
                                        AccountantContactFax = new AccountantContactFax()
                                        {
                                            AccountantContactFaxNumber = new AccountantContactFaxNumber()
                                            {
                                                ContextRef = "journal_context",
                                                Text = "0212222225"
                                            }
                                        },
                                        AccountantContactEmail = new AccountantContactEmail()
                                        {
                                            AccountantContactEmailAddress = new AccountantContactEmailAddress()
                                            {
                                                ContextRef = "journal_context",
                                                Text = "test@test.com.tr"
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        //Entity Headers
                    }
                }
                #region Signature

                //Signature = new Signature()
                //{
                //    Id = "Signature_Id_46dcb742-b202-4691-bc6e-7527ca673d8e",
                //    SignedInfo = new SignedInfo()
                //    {
                //        Id = "Signed_Info_9dc00acc-5eea-477e-a50e-b3d94aa61acd",
                //        CanonicalizationMethod = new CanonicalizationMethod()
                //        {
                //            Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments"
                //        },
                //        SignatureMethod = new SignatureMethod()
                //        {
                //            Algorithm = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256"
                //        },
                //        Reference = new List<Reference>()
                //        {
                //            new Reference()
                //            {
                //                URI = "",
                //                Transforms = new Transforms()
                //                {
                //                    Transform = new Transform()
                //                    {
                //                        Algorithm = "http://www.w3.org/2000/09/xmldsig#enveloped-signature"
                //                    }
                //                },
                //                DigestMethod = new DigestMethod()
                //                {
                //                    Algorithm = "http://www.w3.org/2001/04/xmlenc#sha256"
                //                },
                //                DigestValue = "+CaODsq6rb25LWtQovbuIUwLPWdQn6VxyNe8LGc9kzI="
                //            },
                //            new Reference()
                //            {
                //                Id = "Prop_Ref_Id_9bd4ffb2-eb26-4484-afdb-8d38d79c04a9",
                //                Type = "http://uri.etsi.org/01903#SignedProperties",
                //                URI = "#Prop_Id_18a71503-483a-4519-ac0f-2a35f28d69ac",
                //                DigestMethod = new DigestMethod()
                //                {
                //                    Algorithm = "http://www.w3.org/2001/04/xmlenc#sha256"
                //                },
                //                DigestValue = "V1psBlUUtQZ+PTOq/zv3nGls0cTtWtWfp9umYNXI6nw="
                //            }
                //        }
                //    },
                //    SignatureValue = new SignatureValue()
                //    {
                //        Id = "Signature_Value_2e5ae898-670e-440d-a4ab-ad64884ebc8b",
                //        Text = "H0406bwVGwUWwrbz97tOF5lIiOEo1vhxBbVoOESst3lL/4yGx8FJDItzNXdblTswhd8ev75xLJ1+//9rVMeblVBYI2RGEVmLsdS0XGl9WxP9hYmyesenvIwHlUxv1daeU64IfJPUBuOzmks3kA85Phie54U9ZjXY2liMpuSuQoL/GW1aQhzXI+I9rsnczP2b2Ts3EyjUfAQlEUYiK9dQ3Ku3b/vLGEu4D/wFV6UMnOhuUabbhZ43NxWDCiVt2voB+itOAZSy6zkp6vwospJr5L5EXnKi5dUZ5e4ybsKJfIZF/8ejUuoPwOjhkK5WfEL8+wf43A15o6GSWuhnCIR2AQ=="
                //    },
                //    KeyInfo = new KeyInfo()
                //    {
                //        KeyValue = new KeyValue()
                //        {
                //            RSAKeyValue = new RSAKeyValue()
                //            {
                //                Modulus = "hzz1s1AZoYRMCk8HEzcX2f5mNlSP1ZtvHF1iwZPl+mJm3nm2t2enYxccyxuUZukJfHL+dgsn8Wc3GojAfZGp7HFKDGwTYf+rxaHbjooyUzbZIYGiR1RLwXs1J3nwwnoty9QHLqF0FL8gIWhs5Em/CeldV02CVtL8rgkUWA+42flOAYS69WPvB0192gw26vTTf+yIlnmggm3dOEipiGZUCkJ6wmFFfV2f6GDx0TF6ztXA4iVDadEtbKDaH+ucGdHOIMAihP1YwK18oYfJLZsLlsrx+3U4kBOwLOSPU06/lALEC1pN+zLU+Qi52nfyTI95Csw/VNNtSvVI8FaoZo2QEQ==",
                //                Exponent = "AQAB"
                //            }
                //        },
                //        X509Data = new X509Data()
                //        {
                //            X509Certificate = "CN=Test Kurum Sekiz,2.5.4.5=#130a31323334353637383038",
                //            X509SubjectName = "MIIFiTCCBHGgAwIBAgIIAPSDtsQCYcEwDQYJKoZIhvcNAQELBQAwXDELMAkGA1UEBhMCVFIxTTBLBgNVBAMMRE1hbGkgTcO8aMO8ciBFbGVrdHJvbmlrIFNlcnRpZmlrYSBIaXptZXQgU2HEn2xhecSxY8Sxc8SxIC0gU8O8csO8bSAxMB4XDTE2MDIxMDE1MTAzM1oXDTE5MDIwOTE1MTAzM1owMDETMBEGA1UEBRMKMTIzNDU2NzgwODEZMBcGA1UEAwwQVGVzdCBLdXJ1bSBTZWtpejCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAIc89bNQGaGETApPBxM3F9n+ZjZUj9WbbxxdYsGT5fpiZt55trdnp2MXHMsblGbpCXxy/nYLJ/FnNxqIwH2RqexxSgxsE2H/q8Wh246KMlM22SGBokdUS8F7NSd58MJ6LcvUBy6hdBS/ICFobORJvwnpXVdNglbS/K4JFFgPuNn5TgGEuvVj7wdNfdoMNur003/siJZ5oIJt3ThIqYhmVApCesJhRX1dn+hg8dExes7VwOIlQ2nRLWyg2h/rnBnRziDAIoT9WMCtfKGHyS2bC5bK8ft1OJATsCzkj1NOv5QCxAtaTfsy1PkIudp38kyPeQrMP1TTbUr1SPBWqGaNkBECAwEAAaOCAnkwggJ1MB8GA1UdIwQYMBaAFEYgqVMbKAwcrvIoUYOzHr7yUxR8MB0GA1UdDgQWBBTi+/Z/uhu1Gxo8y9cuLIShB0aLPzAOBgNVHQ8BAf8EBAMCB4AwggEzBgNVHSAEggEqMIIBJjCCASIGC2CGGAECAQEFBwQBMIIBETAqBggrBgEFBQcCARYeaHR0cDovL2RlcG8ua2FtdXNtLmdvdi50ci9pbGtlMIHiBggrBgEFBQcCAjCB1R6B0gBCAHUAIABzAGUAcgB0AGkAZgBpAGsAYQAgAGkAbABlACAAaQBsAGcAaQBsAGkAIABzAGUAcgB0AGkAZgBpAGsAYQAgAHUABnAHUAbABhAG0AYQAgAGUAcwBhAHMAbABhAHIBMQBuATEAIABvAGsAdQBtAGEAawAgAGkA5wBpAG4AIABiAGUAbABpAHIAdABpAGwAZQBuACAAdwBlAGIAIABzAGkAdABlAHMAaQBuAGkAIAB6AGkAeQBhAHIAZQB0ACAAZQBkAGkAbgBpAHoALjAMBgNVHRMBAf8EAjAAMBYGA1UdJQQPMA0GC2CGGAECAQEFBzIBMEEGA1UdHwQ6MDgwNqA0oDKGMGh0dHA6Ly9kZXBvLmthbXVzbS5nb3YudHIva3VydW1zYWwvbW1lc2hzLXMxLmNybDCBggYIKwYBBQUHAQEEdjB0MDwGCCsGAQUFBzAChjBodHRwOi8vZGVwby5rYW11c20uZ292LnRyL2t1cnVtc2FsL21tZXNocy1zMS5jcnQwNAYIKwYBBQUHMAGGKGh0dHA6Ly9jaXNkdXBtbXMxLmt1cnVtc2FsLmthbXVzbS5nb3YudHIwDQYJKoZIhvcNAQELBQADggEBAIrY0OlTatDnCNPg6o49ZrTAubYb9+iHEH9LNF73WbgM3okmaSNnJGo8bwqlACbbKbZhXTh6MUqBo12RqbWxn9t5MdKTjGa/pQtuxmCDMpi/nYzAw6OZ9xMt5y8Ask0mBGAQA2K4tdfGmjuBox+K7o/rNfYkUmYi3JjPtl3XvVjOzWgD9FQn5/SVbELaR21omJNhnKXO3B+8aZHE/2UP5kXwXBdSRNOQkUAt+oRwl+s4tX6BGbx3TPMM0gmd51op8nzT4A07063v0Z2Xz8+dhIR3S40MVErJDxqkMTMuw/Kpue6Fpv2Wg6sndvOXjNnMIXUtKvFh3Iqb+zDeAo0NTVw="
                //        }
                //    },
                //    Object = new XBRLObject()
                //    {
                //        QualifyingProperties = new QualifyingProperties()
                //        {
                //            SignedProperties = new SignedProperties()
                //            {
                //                Id = "Prop_Id_18a71503-483a-4519-ac0f-2a35f28d69ac",
                //                SignedSignatureProperties = new SignedSignatureProperties()
                //                {
                //                    SignerRole = new SignerRole()
                //                    {
                //                        ClaimedRoles = new ClaimedRoles()
                //                        {
                //                            ClaimedRole = "Tedarikçi"
                //                        }
                //                    },
                //                    SigningCertificate = new SigningCertificate()
                //                    {
                //                        Cert = new Cert()
                //                        {
                //                            CertDigest = new CertDigest()
                //                            {
                //                                DigestMethod = new DigestMethod()
                //                                {
                //                                    Algorithm = "http://www.w3.org/2001/04/xmlenc#sha256"
                //                                },
                //                                DigestValue = "k+Em8GKG/ahjqDmwrDylKkac9bzuC/5RmitlEwNFNuM="
                //                            },
                //                            IssuerSerial = new IssuerSerial()
                //                            {
                //                                X509IssuerName = "CN=Mali Mühür Elektronik Sertifika Hizmet Sağlayıcısı - Sürüm 1, C=TR",
                //                                X509SerialNumber = "68824715313177025"
                //                            }
                //                        }
                //                    },
                //                    SigningTime = "2017-04-06T14:51:12.775+03:00"
                //                }
                //            },
                //            Target = "#Signature_Id_46dcb742-b202-4691-bc6e-7527ca673d8e"
                //        }
                //    }
                //} 
                #endregion
            };

            var record = GetEntryHeaders();
            defter.Xbrl.AccountingEntries.EntryHeader = record;

            XmlManager oXmlManager = new XmlManager();
            string xmlText = oXmlManager.Serialize(defter, "yevmiye.xslt");
            
            XDocument xDocument = XDocument.Parse(xmlText.Remove(0, 1));
            Console.Clear();
            //Console.WriteLine(xDocument.ToString());

            /*    */

            List<EDefter> list = new List<EDefter>()
            {
                new EDefter()
                {
                    Id = 1,
                    FirstName = "Berkay",
                    LastName = "AKÇAY"
                },
                new EDefter()
                {
                    Id = 1,
                    FirstName = "Berkay",
                    LastName = "AKÇAY"
                },
                new EDefter()
                {
                    Id = 1,
                    FirstName = "Berkay",
                    LastName = "AKÇAY"
                },
                new EDefter()
                {
                    Id = 1,
                    FirstName = "Berkay",
                    LastName = "AKÇAY"
                },
                new EDefter()
                {
                    Id = 1,
                    FirstName = "Berkay",
                    LastName = "AKÇAY"
                },
            };
            

            //CreateCSVFromGenericList(list, "export.csv");

            bool folderExists = Directory.Exists($"{Directory.GetCurrentDirectory()}\\VOLANT\\eSystems\\eDefter");
            if (!folderExists)
            {
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\VOLANT\\eSystems\\eDefter");
            }
            CreateCSVFromGenericList(list, $"{Directory.GetCurrentDirectory()}\\VOLANT\\eSystems\\eDefter\\export.csv");

            folderExists = false;

            folderExists = Directory.Exists($"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}VOLANT\\eSystems\\eDefter");
            if (!folderExists)
            {
                Directory.CreateDirectory($"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}VOLANT\\eSystems\\eDefter");
            }
            CreateCSVFromGenericList(list, $"{Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())}VOLANT\\eSystems\\eDefter\\export.csv");
            Process.Start("explorer.exe", $"{Directory.GetCurrentDirectory()}\\VOLANT\\eDefter");
            Console.ReadKey();
        }

        public static List<EntryHeader> GetEntryHeaders()
        {
            List<EntryHeader> entryHeaders = new List<EntryHeader>();

            EntryHeader entryHeader = new EntryHeader()
            {
                EnteredBy = new EnteredBy()
                {
                    ContextRef = "journal_context",
                    Text = "Berkay AKÇAY"
                },
                EnteredDate = new EnteredDate()
                {
                    ContextRef = "journal_context",
                    Text = "2017-01-01"
                },
                EntryNumber = new EntryNumber()
                {
                    ContextRef = "journal_context",
                    Text = "000001"
                },
                EntryComment = new EntryComment()
                {
                    ContextRef = "journal_context",
                    Text = "2016 yılı devreden bakiye."
                },
                TotalCredit = new TotalCredit()
                {
                    ContextRef = "journal_context",
                    Decimals = "INF",
                    UnitRef = "try",
                    Text = "1003425"
                },
                TotalDebit = new TotalDebit()
                {
                    ContextRef = "journal_context",
                    Decimals = "INF",
                    UnitRef = "try",
                    Text = "1003425"
                },
                EntryNumberCounter = new EntryNumberCounter()
                {
                    ContextRef = "journal_context",
                    Decimals = "INF",
                    UnitRef = "countable",
                    Text = "1"
                },
                EntryDetail = new List<EntryDetail>()
                {
                    new EntryDetail()
                    {
                        LineNumber = new LineNumber()
                        {
                            ContextRef = "journal_context",
                            Text = "1"
                        },
                        LineNumberCounter = new LineNumberCounter()
                        {
                            ContextRef = "journal_context",
                            Decimals = "INF",
                            UnitRef = "countable",
                            Text = "1"
                        },
                        Account = new Account()
                        {
                            AccountMainID = new AccountMainID()
                            {
                                ContextRef = "journal_context",
                                Text = "100"
                            },
                            AccountMainDescription = new AccountMainDescription()
                            {
                                ContextRef = "journal_context",
                                Text = "KASA"
                            },
                            AccountSub = new AccountSub()
                            {
                                AccountSubID = new AccountSubID()
                                {
                                    ContextRef = "journal_context",
                                    Text = "100.01"
                                },
                                AccountSubDescription = new AccountSubDescription()
                                {
                                    ContextRef = "journal_context",
                                    Text = "TL Kasası"
                                }
                            }
                        },
                        Amount = new Amount()
                        {
                            ContextRef = "journal_context",
                            Decimals = "INF",
                            UnitRef = "try",
                            Text = "925"
                        },
                        DebitCreditCode = new DebitCreditCode()
                        {
                            ContextRef = "journal_context",
                            Text = "D"
                        },
                        PostingDate = new PostingDate()
                        {
                            ContextRef = "journal_context",
                            Text = "2017-01-01"
                        },
                        DocumentReference = new DocumentReference()
                        {
                            ContextRef = "journal_context",
                            Text = "000001"
                        },
                        DetailComment = new DetailComment()
                        {
                            ContextRef = "000001",
                            Text = "2016 yılı devreden bakiye."
                        }
                    }
                }

            };

            entryHeaders.Add(entryHeader);

            return entryHeaders;
        }

        public class EDefter
        {
            public Int64 Id { get; set; }
            public String FirstName { get; set; }
            public String LastName { get; set; }
        }

        /// <summary>
        /// Creates the CSV from a generic list.
        /// </summary>;
        /// <typeparam name="T"></typeparam>;
        /// <param name="list">The list.</param>;
        /// <param name="csvNameWithExt">Name of CSV (w/ path) w/ file ext.</param>;
        public static void CreateCSVFromGenericList<T>(List<T> list, string csvNameWithExt)
        {
            if (list == null || list.Count == 0) return;

            //get type from 0th member
            Type t = list[0].GetType();
            string newLine = Environment.NewLine;

            FileStream fs = null;
            fs = new FileStream(csvNameWithExt, FileMode.CreateNew);

            using (var sw = new StreamWriter(fs, Encoding.UTF8, 512))
            {
                //make a new instance of the class name we figured out to get its props
                object o = Activator.CreateInstance(t);
                //gets all properties
                PropertyInfo[] props = o.GetType().GetProperties();

                //foreach of the properties in class above, write out properties
                //this is the header row
                foreach (PropertyInfo pi in props)
                {
                    sw.Write(pi.Name + ";");
                }
                sw.Write(newLine);

                //this acts as datarow
                foreach (T item in list)
                {
                    //this acts as datacolumn
                    foreach (PropertyInfo pi in props)
                    {
                        //this is the row+col intersection (the value)
                        string whatToWrite =
                            Convert.ToString(item.GetType()
                                    .GetProperty(pi.Name)
                                    .GetValue(item, null))
                                .Replace(';', ' ') + ';';

                        sw.Write(whatToWrite);

                    }
                    sw.Write(newLine);
                }
            }
        }
    }
}
