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
        public String bTextStart { get; }
        public String bTextEnd { get; }
        
        public MainPage()
        {
            InitializeComponent();

            bTextStart= "Some Binding Stuff Text!";
            //Create New List of monkeys:
            Monkeys = new List<Monkey>
            {
                new Monkey
                {
                    Name = "Blue Nosed Baboon",
                    Location = "Africa & Asia",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/27/Baby_ginger_monkey.jpg"
                },
                new Monkey
                {
                   Name = "Black Eyed Baboon",
                   Location = "NE England",
                   ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/93/Mandril.jpg"
                }
            };

            bTextEnd = "SomeMoreBindingText!";

            BindingContext = this;
        }

        //"OnMonkeyList1Selected" ItemTapped="OnMonkeyList1Tapped"/
        void OnMonkeyList1Selected(object mLIst1, SelectedItemChangedEventArgs m)
        {
            Monkey selMonkey = m.SelectedItem as Monkey;
        }

        void OnMonkeyList1Tapped(object mList1, ItemTappedEventArgs m)
        {
            Monkey tappedItem = m.Item as Monkey;
        }
    }
}
