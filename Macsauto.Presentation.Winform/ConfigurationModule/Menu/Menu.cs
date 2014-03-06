using System;
using System.Drawing;
using System.Windows.Forms;

namespace Macsauto.Presentation.WinForm.ConfigurationModule
{
    public class Menu
    {
        private readonly string _index;
        private readonly string _text;
        private readonly Image _buttonImage;
        private readonly Menu[] _children;
        private readonly Action _action;

        public Menu(string index, string text)
        {
            _index = index;
            _text = text;
        }

        public Menu(string index, string text, Action action = null)
        {
            _index = index;
            _text = text;
            _action = action;
        }

        public Menu(string index, string text, Image buttonImage)
        {
            _index = index;
            _text = text;
            _buttonImage = buttonImage;
        }

        public Menu(string index, string text, Menu[] children)
        {
            _index = index;
            _text = text;
            _children = children;
        }

        public Menu(string index, string text, Image buttonImage, Menu[] children)
        {
            _index = index;
            _text = text;
            _buttonImage = buttonImage;
            _children = children;
        }

        public string Index
        {
            get { return _index; }
        }

        public string Text
        {
            get { return _text; }
        }

        public Image ButtonImage
        {
            get { return _buttonImage; }
        }

        public Menu[] Children
        {
            get { return _children; }
        }

        public Action Action
        {
            get { return _action; }
        }

        public bool HasChildren
        {
            get { return _children != null && _children.Length > 0; }
        }
    }
}