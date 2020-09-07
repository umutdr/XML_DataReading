using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_DataReading.Models;

namespace XML_DataReading
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNodeList xmlNodeList;
            XmlNode xmlNode;

            List<Product> products = new List<Product>();
            Product product = null;

            xmlDoc.Load("grisport.xml");
            xmlNodeList = xmlDoc.GetElementsByTagName("urun");

            foreach (XmlNode node in xmlNodeList)
            {
                product = new Product();
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    switch (childNode.Name)
                    {
                        case "UrunID":
                            product.UrunID = childNode.InnerText; break;
                        case "UrunAdi":
                            product.UrunAdi = childNode.InnerText; break;
                        case "Kod":
                            product.Kod = childNode.InnerText; break;
                        case "Fiyat":
                            product.Fiyat = childNode.InnerText; break;
                        case "ListFiyat":
                            product.ListFiyat = childNode.InnerText; break;
                        case "KdvOran":
                            product.KdvOran = childNode.InnerText; break;
                        case "Marka":
                            product.Marka = childNode.InnerText; break;
                        case "Aciklama":
                            product.Aciklama = childNode.InnerText; break;
                        case "ImageName":
                            product.ImageName = childNode.InnerText; break;
                        case "Kategori":
                            product.Kategori = childNode.InnerText; break;
                        case "Renk":
                            product.Renk = childNode.InnerText; break;
                        case "Stoklar":
                            if (childNode.HasChildNodes == true && childNode.ChildNodes.Count > 1)
                            {
                                foreach (XmlNode childChildNode in childNode.ChildNodes)
                                {
                                    string childChildNodeName = childChildNode.Name;
                                }
                            }

                            product.Stoklar = childNode.InnerText;

                            break;
                        default:
                            break;
                    }
                }
                products.Add(product);
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.UrunID}");
                Console.WriteLine($"{item.UrunAdi}");
                Console.WriteLine($"{item.Kod}");
                Console.WriteLine($"{item.Fiyat}");
                Console.WriteLine($"{item.ListFiyat}");
                Console.WriteLine($"{item.KdvOran}");
                Console.WriteLine($"{item.Marka}");
                Console.WriteLine($"{item.Aciklama}");
                Console.WriteLine($"{item.ImageName}");
                Console.WriteLine($"{item.Kategori}");
                Console.WriteLine($"{item.Renk}");
                Console.WriteLine($"{item.Stoklar}");
                Console.WriteLine("\n\n\n");
            }

            Console.WriteLine($"{products.Count} Rows product ready!");
            Console.ReadKey();
        }
    }
}
