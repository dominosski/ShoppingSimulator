using ShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoShop
{
    public partial class DemoShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;
        public DemoShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items.Where(x => x.Sold==false).ToList();
            itemsListBox.DataSource = itemsBinding;

            itemsListBox.DisplayMember = "Show";
            itemsListBox.ValueMember = "Show";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartlistBox.DataSource = cartBinding;

            shoppingCartlistBox.DisplayMember = "Show";
            shoppingCartlistBox.ValueMember = "Show";

            vendorsBinding.DataSource = store.Vendors;
            vendorsListBox.DataSource = vendorsBinding;

            vendorsListBox.DisplayMember = "Show";
            vendorsListBox.ValueMember = "Show";

        }

        private void SetupData()
        {
            store.Vendors = new List<Vendor>();
            store.Vendors.Add(new Vendor { FirstName = "Axel", LastName = "Ryan"});
            store.Vendors.Add(new Vendor { FirstName = "Michael", LastName = "Stanley"});

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A tale of two cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "The Witcher",
                Description = "A book about the butcher of Blaviken",
                Price = 12.20M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title ="The lord of the rings",
                Description = "A book about the good and the evil",
                Price = 7.40M,
                Owner = store.Vendors[0]
            });

            store.Name = "";


        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);

        }

        private void makePurchase_Click(object sender, EventArgs e)
        {
            foreach  (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }
            shoppingCartData.Clear(); 
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storePayoutValue.Text = string.Format("${0}", storeProfit);

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
