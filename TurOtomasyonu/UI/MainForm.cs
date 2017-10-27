using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurOtomasyonu.Models;
using TurOtomasyonu.Services.DataServices;
using TurOtomasyonu.Services.InfrastructureService;

namespace TurOtomasyonu.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        TourCategoryRepository repo = new TourCategoryRepository(new Models.ProjectContext());
        TourRepository Trepo = new TourRepository(new Models.ProjectContext());

        private void MainForm_Load(object sender, EventArgs e)
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Detayı Görüntüle",new EventHandler(DetailClick));
            menu.MenuItems.Add("Yorumlar",new EventHandler(CommentClick));

            lstTours.ContextMenu = menu;

            #region Visible

            grpTourDate.Visible = false;

            #endregion

            #region Combobox Doldurma

            
            var data = repo.SelectTopCategories();

            cmbCategories.DataSource = data;
            cmbCategories.DisplayMember = "CategoryName";

            #endregion

            #region TourSaatleri

            dtStartDate.MinDate = DateTime.Now;
            dtStartDate.MaxDate = DateTime.Now.AddMonths(3);
            dtStartDate.Format = DateTimePickerFormat.Short;

            dtEndDate.MinDate = DateTime.Now.AddDays(7);
            dtEndDate.MaxDate = DateTime.Now.AddMonths(3);
            dtEndDate.Format = DateTimePickerFormat.Short;

            #endregion

            #region ListViewDoldurma Tarihe Göre

            var selectedItem = cmbSubCategories.SelectedItem as TourCategory;

            lstTours.Items.Clear();

            var dTour = Trepo.SelectTourByDate(dtStartDate.Value.AddDays(-1), dtEndDate.Value,selectedItem).ToList();

            dTour.ForEach(item =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.TourName;
                li.SubItems.Add(item.Quota.ToString());
                li.SubItems.Add(item.Price.ToString());
                li.Tag = item;

                lstTours.Items.Add(li);
            });


            #endregion


        }

        private void CommentClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DetailClick(object sender, EventArgs e)
        {
            //unboxing 
            Tour t = lstTours.FocusedItem.Tag as Tour;
            lblDetail.Text = t.Description;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpTourDate.Visible = true;
            TourCategory selected = cmbCategories.SelectedItem as TourCategory;

            var data = repo.SelectSubCategoriesById(selected.Id);

            cmbSubCategories.DataSource = data;
            cmbSubCategories.DisplayMember = "CategoryName";

            var selectedItem = cmbSubCategories.SelectedItem as TourCategory;

            lstTours.Items.Clear();

            var dTour = Trepo.SelectTourByDate(dtStartDate.Value.AddDays(-1), dtEndDate.Value, selectedItem).ToList();

            dTour.ForEach(item =>
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.TourName;
                li.SubItems.Add(item.Quota.ToString());
                li.SubItems.Add(item.Price.ToString());
                li.Tag = item;

                lstTours.Items.Add(li);
            });



        }

        private void dtStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpCategory_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var service = new PaymentService();
            service.type = PaymentType.Cash;
            TourRepository repo = new TourRepository(service);
            repo.Pay(new List<Customer>(), new Tour());

        }

     
    }
}
