using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace RectangleLabs
{
    [Serializable]
    public class Comment
    {
        [XmlAttribute]
        public string text;
        public string Text { get { return text; } }
        public Rectangle Rectangle { get { return rectangle; } }
        [XmlAttribute]
        public int x1, y1, x2, y2;
        public int X1 { get { return x1; } }
        public int Y1 { get { return y1; } }
        public int X2 { get { return x2; } }
        public int Y2 { get { return y2; } }
        private Rectangle rectangle;
        public Comment()
        {

        }
        public Comment(string _text, Rectangle _rectangle)
        {
            this.text = _text;
            this.rectangle = _rectangle;
            x1 = this.Rectangle.Location.X;
            y1 = this.Rectangle.Location.Y;
            x2 = this.Rectangle.Size.Width;
            y2 = this.Rectangle.Size.Height;
        }
        static public void Serealize_it(List<Comment> objectGrath, string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Comment>));
            using (Stream fStream = new FileStream(filename,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlSerializer.Serialize(fStream, objectGrath);
            }
        }
        static public void Deserealize_it(string filename, out List<Comment> lst)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Comment>));
            using (Stream fStream = new FileStream(filename, FileMode.OpenOrCreate,
                FileAccess.Read))
            {
                lst = (List<Comment>)xmlSerializer.Deserialize(fStream);
            }
        }
    }
}
