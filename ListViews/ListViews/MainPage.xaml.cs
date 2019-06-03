using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViews
{
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set;}
        public MainPage()
        {
            InitializeComponent();

            //Create New List of monkeys:
            Monkeys = new List<Monkey>
            {
                new Monkey
                {
                    Name = "Blue Nosed Baboon",
                    Location = "Africa & Asia",
                    //ImageUrl =
                    //    "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
                }
            };


            BindingContext = this;
        }
    }
}
