using Day27Prac26.Interfaces;
using Day27Prac26.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;


namespace Day27Prac26.Share
{
    internal class XmlDocumentSweets : IXmlSweets
    {
        private readonly XmlDocument _document;
            private string _xmlFilePath;
       


        public void Add(SweetsSet sweets)
        {
            var xRoot = _document.DocumentElement;

            XmlElement sweetsElem = _document.CreateElement("sweet");
            XmlAttribute typeSweetsAttribute = _document.CreateAttribute("Type sweets");
            XmlText xmlText = _document.CreateTextNode(sweets.TypeSweets);
            typeSweetsAttribute.AppendChild(xmlText);

            sweetsElem.AppendChild(sweetsElem);

            XmlElement typeFrillElem = _document.CreateElement("Type Frill");
            XmlText typeFrillText = _document.CreateTextNode(sweets.TypeFrill);
            typeFrillElem.AppendChild(typeFrillElem);

            XmlElement priceElem = _document.CreateElement("Price");
            XmlText priceText = _document.CreateTextNode(sweets.Price.ToString());
            priceElem.AppendChild(priceElem);

             xRoot.AppendChild(sweetsElem);
            _document.Save(_xmlFilePath);
        }


        public void Load(string xmlFieleRath)
        {
            _xmlFilePath = xmlFieleRath;
            _document.Load(xmlFieleRath);
        }
        public SweetsSet FindBy(string typesweet)
        {
            SweetsSet sweet = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                sweet = GetSweet(xNode);
                if (sweet.TypeSweets.Equals(typesweet))
                {
                    return sweet;
                }
            }
            return sweet;
        }

        private SweetsSet GetSweet(XmlNode xNode)
        {
            var sweets = new SweetsSet();
            if (xNode.Attributes.Count > 0)
            {
                var attributeName = xNode.Attributes.GetNamedItem("type sweets");
                sweets.TypeSweets = attributeName?.Value;
            }
            foreach (XmlNode childNode in xNode.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("type frill"))
                    {
                        sweets.TypeFrill = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("price"))
                        sweets.Price = int.Parse(childNode.InnerText);
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {

                }
            }
            return sweets;
        }
    }
    }
    


