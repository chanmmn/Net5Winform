namespace WinAppSortDataGridView
{
    public partial class Form1 : Form
    {
        ItemList itemList = new ItemList();
        public Form1()
        {
            InitializeComponent();
            
            itemList.lstItem = new List<Item> { new Item { ItemId= 1,ItemDescription= "One" },
                { new Item { ItemId= 2,ItemDescription= "Two"  } },
                { new Item { ItemId= 3,ItemDescription= "Three"  } },
                { new Item { ItemId= 4,ItemDescription= "Four"  } },
                { new Item { ItemId= 5,ItemDescription= "Five"  } }
            };
        }

        private void btnData_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = itemList;
            //dataGridView1.DataMember = "lstItem";
            ItemList itemList1 = new ItemList();
            itemList1.lstItem = itemList.lstItem.OrderBy(r => r.ItemDescription).ToList();
            dataGridView1.DataSource = itemList1;
            dataGridView1.DataMember = "lstItem";
        }
    }
}
