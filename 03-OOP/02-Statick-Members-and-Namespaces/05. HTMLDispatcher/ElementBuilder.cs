using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLDispatcher
{
    public class ElementBuilder
    {
        private string element, atribute, value, content;

        private static string finalResult = String.Empty;
        private StringBuilder fullAtribute = new StringBuilder();
        private StringBuilder contentBuilder = new StringBuilder();

        public ElementBuilder(string element)
        {
            this.Element = element;
        }

        public string Element
        {
            get { return this.element; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Element cannot be null");
                }
                this.element = value;
            }
        }

        public string Atribute
        {
            get { return this.atribute; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Atribute cannot be null");
                }
                this.atribute = value;
            }
        }

        public string Value
        {
            get { return this.value; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value cannot be null");
                }
                this.value = value;
            }
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Content cannot be null");
                }
                this.content = value;
            }
        }

        public void AddAttribute(string atribute, string value)
        {
            fullAtribute.Append(string.Format(@"{0}=""{1}"" ",
                atribute,
                value));
        }

        public void AddContent(string content)
        {
            this.contentBuilder.AppendLine(content);
        }

        public static ElementBuilder operator *(ElementBuilder a, int count)
        {
            if (count <= 0)
            {
                throw new  ArgumentOutOfRangeException("Count must be greater then zero");
            }
            for (int i = 0; i < count; i++)
            {

            }
            return null;
        }

        private void BuildResult(StringBuilder atribute, StringBuilder content)
        {
            Console.WriteLine("<{0} {1}>{2}</{0}>",
                this.Element,
                this.Atribute,
                this.Content);
        }
    }
}
