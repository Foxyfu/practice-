using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

using Task1.Interfaces;
using Task1.Models;

namespace Task1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private string _path;

        public XmlDocumentWorker()
        {
            _document = new XmlDocument();
        }

        public void Add(Record record)
        {
            XmlElement xRoot = _document.DocumentElement;
            XmlElement recordElem = _document.CreateElement("record");

            recordElem.SetAttribute("surname", record.Surname);

            XmlElement birthdayElem = _document.CreateElement("birthday");
            XmlText birthdayTxt = _document.CreateTextNode(record.Birthday);
            birthdayElem.AppendChild(birthdayTxt);

            recordElem.AppendChild(birthdayElem);

            XmlElement phoneElem = _document.CreateElement("phone");
            XmlText phoneTxt = _document.CreateTextNode(record.Phone);
            phoneElem.AppendChild(phoneTxt);

            recordElem.AppendChild(phoneElem);

            xRoot.AppendChild(recordElem);
            _document.Save(_path);
        }

        public void Delete(string Surname)
        {
            XmlElement xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                try
                {
                    if (xNode.Attributes.GetNamedItem("surname").InnerText.Equals(Surname))
                    {
                        xRoot.RemoveChild(xNode);
                    }
                }
                catch { }
            }
            _document.Save(_path);
        }

        private Record GetRecord(XmlNode xNode)
        {
            Record result = null;
            XmlNode surnameAttr = null;
            if (xNode.Attributes.Count > 0)
            {
                surnameAttr = xNode.Attributes.GetNamedItem("surname");
            }
            string birthday = "", phone = "";
            foreach (XmlNode childNode in xNode.ChildNodes)
            {
                try
                {
                    if(childNode.Name.Equals("birthday"))
                        birthday = childNode.InnerText;
                    if (childNode.Name.Equals("phone"))
                        phone = childNode.InnerText;
                    result = new Record(surnameAttr.Value, birthday, phone);
                }
                catch{ }
            }
            return result;
        }

        public Record GetBySurname(string Surname)
        {
            Record result = null;
            XmlElement xRoot = _document.DocumentElement;
            foreach(XmlNode xNode in xRoot)
            {
                result = GetRecord(xNode);
                if (result.Surname.Equals(Surname))
                    return result;
            }
            return null;
        }

        public List<Record> GetAll()
        {
            List<Record> result = new List<Record>();
            XmlElement xRoot = _document.DocumentElement;
            foreach(XmlNode xNode in xRoot)
            {
                Record record = GetRecord(xNode);
                result.Add(record);
            }
            return result;
        }

        public void Load(string Path)
        {
            _path = Path;
            _document.Load(_path);
        }
    }
}
