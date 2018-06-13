using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        // a decimal object that will hold the store profit
        private decimal storeProfit = 0;

        // create a Store object from Stores.cs since it has a List of Vendors and Items
        private Store store = new Store();

        // The binding source will link your windows forms to your items that are store
        // create binding source -> binding source = link -> windows form = binding source
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();

        // A list to hold the items stored in the user's shopping cart
        private List<Item> shoppingCartData = new List<Item>();

        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();
            SetupListBoxData();
        }

        // This will create some dummy data
        private void SetupData()
        {
            // Create a vendor object
            Vendor v1 = new Vendor();

            // add the attribute values to v1
            v1.FirstName = "James"; v1.LastName = "Patterson";

            // add v1 to the store list
            store.Vendors.Add(v1);

            // Alternatively, you can create a new object like a method 
            Vendor v2 = new Vendor
            {
                FirstName = "Bruce",
                LastName = "Wayne"
            };

            // add the new object to the store list
            store.Vendors.Add(v2);

            // This is the same as the code above, but slightly different syntax
            store.Vendors.Add(new Vendor { FirstName = "Clark", LastName = "Kent" });
            store.Vendors.Add(new Vendor { FirstName = "Preston", LastName = "Sapp" });
            store.Vendors.Add(new Vendor { FirstName = "Devin", LastName = "Clark" });
            store.Vendors.Add(new Vendor { FirstName = "Ronda", LastName = "Rousey" });
            store.Vendors.Add(new Vendor { FirstName = "Joe", LastName = "Rogan" });

            //
            store.Items.Add(new Item
                            {   Title = "Moby Dick",
                                Description = "Whales",
                                Price = 2.50M,
                                Owner = store.Vendors[0]
                            });
            store.Items.Add(new Item
                            {
                                Title = "Fight Club",
                                Description = "A tale of ...",
                                Price = 3.25M,
                                Owner = store.Vendors[1]
                            });
            store.Items.Add(new Item
                            {
                                Title = "Visual Studio 2018 C# Tutorial",
                                Description = "Tutorial on C#",
                                Price = 13.50M,
                                Owner = store.Vendors[2]
                            });
            store.Items.Add(new Item
                            {
                                Title = "Laptop : Dell : 20 GB 3.5 GHZ",
                                Description = "Laptop",
                                Price = 400.50M,
                                Owner = store.Vendors[0]
                            });

            // 
            store.Name = "Consignment in Seconds";   
        }

        protected void SetupListBoxData()
        {
            // This will link our binding source to the items in our store
            // but it will only provide data where the sold attribute is set to false 
            // using a lambda expression. The return is a list, not a iNumerable
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.DataSource = shoppingCartData;
            vendorsBinding.DataSource = store.Vendors;

            // this will link our listboxes to our binding source itemsBinding
            itemsListBox.DataSource = itemsBinding;
            shoppingCartListBox.DataSource = cartBinding;
            vendorListBox.DataSource = vendorsBinding;

            // get the information you're seeking to display using the method Display
            itemsListBox.DisplayMember = "Display";
            shoppingCartListBox.DisplayMember = "Display";
            vendorListBox.DisplayMember = "Display";

            // use this to actually populate the form with the data created out of Display
            itemsListBox.ValueMember = "Display";
            shoppingCartListBox.ValueMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            // get the item that is selected in the items list
            Item selectedItem = (Item)itemsListBox.SelectedItem;

            // add the items to the shopping cart list
            shoppingCartData.Add(selectedItem);

            // reset the bindings or else the data will not show up in the shopping cart
            // If you modify the list at all, you have to call the reset bindings
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            // create a loop to gather all of the data from the shopping cart
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;

                // This will take the owners commission and minus it from 1
                // yielding the stores take. 
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            // clear the shopping cart data once purchases, via sold
            shoppingCartData.Clear();

            // this will set the store's profit label accordingly
            storeProfitValue.Text = string.Format("${0}", storeProfit);

            // don't forget to reset the bindings 
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);

            // This will refresh our itemsListBox
            // to show updated data
            SetupListBoxData();
        }
    }
}
