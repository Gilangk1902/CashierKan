using CashierKan.Controllers;
using CashierKan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashierKan.Views
{
    public partial class Browse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadItems();
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text;

            PerformSearch(searchQuery);
        }

        private void LoadItems()
        {
            List<Item> items = ItemController.GetAll();

            ItemGridView.DataSource = items;
            ItemGridView.DataBind();
        }

        private void PerformSearch(string searchQuery)
        {
            List<Item> searchResults = ItemController.SearchItems(searchQuery);

            ItemGridView.DataSource = searchResults;
            ItemGridView.DataBind();
        }

        protected void ItemGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selectedRow = ItemGridView.SelectedRow;

            string name = selectedRow.Cells[0].Text;

            string itemId = ItemController.GetId(name);
            Item selectedItem = ItemController.Get(itemId);

            ItemNameLabel.Text = selectedItem.name;
            PriceLabel.Text = selectedItem.price.ToString();
        }

        private void Unused_SelectedIndexChanged()
        {
            int selectedIndex = ItemGridView.SelectedIndex;
            int itemId = Convert.ToInt32(ItemGridView.DataKeys[selectedIndex].Value);

            string itemIdString = itemId.ToString();
            Item selectedItem = ItemController.Get(itemIdString);

            ItemNameLabel.Text = selectedItem.name;
            PriceLabel.Text = selectedItem.price.ToString();
        }
    }

}