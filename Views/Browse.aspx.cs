using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PSDProject.Controller;
using PSDProject.Model;

namespace PSDProject.Views
{
    public partial class Views : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load all items
                LoadItems();
            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text;
            // Perform search based on searchQuery
            PerformSearch(searchQuery);
        }

        private void LoadItems()
        {
            // Get all items from the database
            List<Item> items = ItemController.GetAllItems();

            // Bind the items to the GridView
            ItemGridView.DataSource = items;
            ItemGridView.DataBind();
        }

        private void PerformSearch(string searchQuery)
        {
            // Perform search based on searchQuery
            List<Item> searchResults = ItemController.SearchItems(searchQuery);

            // Bind the search results to the GridView
            ItemGridView.DataSource = searchResults;
            ItemGridView.DataBind();
        }

        protected void ItemGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item index
            int selectedIndex = ItemGridView.SelectedIndex;

            // Retrieve the selected item from the GridView's DataKeys collection
            int itemId = Convert.ToInt32(ItemGridView.DataKeys[selectedIndex].Value);

            // Get the item details from the database
            string itemIdString = itemId.ToString();
            Item selectedItem = ItemController.GetOneItem(itemIdString);


            // Display the item details
            ItemNameLabel.Text = selectedItem.ItemName;
            PriceLabel.Text = selectedItem.ItemPrice.ToString();
            // Update other labels as needed
        }
    }
}
