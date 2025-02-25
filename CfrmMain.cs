/* Student number: 
 * Surname, intials: 
 * CSIS2614, Assignment 2
 * Date completed: 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Student;

namespace Waste_Management
{
    public partial class CfrmMain : Form
    {
        private Products products = new();

        public CfrmMain()
        {
            InitializeComponent();
        } //ctor

        private void CfrmMain_Load(object sender, EventArgs e)
        {
            ProductType[] types = (ProductType[])Enum.GetValues(typeof(ProductType));
            foreach (ProductType type in types)
                cmboProducts.Items.Add(type);

            lblDm3.Text = "dm\u00B3";
            lblCompressedDm3.Text = "dm\u00B3";
            lblOriginalDm3.Text = "Original volume (dm\u00B3)";

        } //CfrmMain_Load

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        } //btnClose_Click

        private void Display()
        {
            lstbxProducts.DataSource = products.ToList().Select(pr => pr.ToString()).ToList();
            lblOriginalMassA.Text = products.TotalOriginalVolumeA().AsString(1) + " dm\u00B3";
            lblReducedMassA.Text = products.TotalReducedVolumeA().AsString(1) + " dm³";
            lblOriginalMassB.Text = products.TotalOriginalVolumeB().AsString(1) + " dm³";
            lblReducedMassB.Text = products.TotalReducedVolumeB().AsString(1) + " dm³";
            lblOriginalMassC.Text = products.TotalOriginalVolumeC().AsString(1) + " dm³";
            lblReducedMassC.Text = products.TotalReducedVolumeC().AsString(1) + " dm³";
        } //Display

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new((ProductType)cmboProducts.SelectedItem, nudOriginalVolume.Value, nudReductionPercent.Value);
            products.Add(product);
            //lstbxProducts.Items.Add(product.ToString());
            lstbxProducts.DataSource = products.ToList().Select(pr => pr.ToString()).ToList();
            Display();
        } //btnAdd_Click

        private void btnLoadTestData_Click(object sender, EventArgs e)
        {
            string fileName = "C:\\stuff\\Csharp\\Student-2\\test_data.tsv";
            products.Clear();
            if (File.Exists(fileName))
            {
                using (StreamReader f = new StreamReader(fileName))
                {
                    while (!f.EndOfStream)
                    {
                        string[] fields = f.ReadLine().Split("\t");
                        ProductType type = Enum.Parse<ProductType>(fields[0]);
                        decimal original_volume = decimal.Parse(fields[1]);
                        decimal reduction_percent = decimal.Parse(fields[2]);
                        products.Add(new Product(type, original_volume, reduction_percent));
                    }
                } //using f                
                Display();
            } //if file exists
        } //btnLoadTestData_Click
    } //class
} //namespace
