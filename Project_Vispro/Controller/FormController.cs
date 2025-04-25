using Project_Vispro.BudgetingManagementDataSetTableAdapters;
using Project_Vispro.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Vispro.Model;
using System.Collections;
using System.Globalization;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace Project_Vispro.Controller
{
    public class FormController
    {
        private MainForm view;
        private DataSet BudgetingManagementDataSet;
        private ComboBox categoryEarningCb;
        public Form curForm;
        public Form curDialog;
        public Model.ModelUser loggedInUser;
        public object peopleList;
        public object listPeople;
        public ArrayList detailPigetherPeopleList = new ArrayList();
        public CultureInfo culture = new CultureInfo("id-ID");


        public FormController(MainForm view)
        {
            this.view = view;
        }

        #region general form controller

        public void fillDataGridView(DataGridView  myView, object valueList)
        {
            myView.DataSource = null;
            myView.Rows.Clear();
            myView.DataSource = valueList;
        }

        public void changeScreen(Form newForm)
        {
            view.SuspendLayout();
            ClearForm();
            newForm.TopLevel = false;
            newForm.Size = view.mainPanel.Size;
            view.mainPanel.Controls.Add(newForm);
            curForm = newForm;
            newForm.Show();
            view.ResumeLayout(false);

        }
        public void newAddScreen(Form newForm)
        {
            if (curDialog != null)
            {
                curDialog.Dispose();
            }
            view.SuspendLayout();
            newForm.StartPosition = FormStartPosition.CenterScreen;
            curDialog = newForm;
            newForm.ShowDialog();
            newForm.TopMost = true;
            view.ResumeLayout();
        }
        public void closedButton_Click(object sender, EventArgs e)
        {
            Form topScreen = Form.ActiveForm;
            topScreen.Close();
        }

        public void enableSaldoButton(TextBox myBox)
        {
            if (myBox.UseSystemPasswordChar == false)
            {
                myBox.UseSystemPasswordChar = true;
            }
            else
            {
                myBox.UseSystemPasswordChar = false;
            }
        }

        public void renewUserModel()
        {
            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var result = from user in db.Users
                                     where user.user_id == loggedInUser.User_ID
                                     select user;
                    var userResult = result.FirstOrDefault();

                    if (userResult != null) { }
                    ModelUser newUser = new ModelUser(userResult.user_id, userResult.name, userResult.email,
                                            userResult.phone_number, userResult.balances, userResult.savings);
                    loggedInUser = newUser;
                }
        }
        #endregion general form controller

        #region people form controller
        public void PeopleForm_Load(object sender, EventArgs e)
        {
            PeopleForm form = (PeopleForm)curForm;
            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {

                var result = (from people in db.CategoryPeoples
                              where people.user_id == loggedInUser.User_ID
                              select new
                              {
                                  Name = people.people_name
                              }).ToList();

               listPeople = result;
                }
            form.categoryPeopleDataGridView.DataSource = listPeople;
        }
        #endregion

        #region login form controller
        public void registerLinkLabel_DoubleClick(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(view.controller);
            newAddScreen(register);
        }

        public void loginClosedButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = (LoginForm)Form.ActiveForm;
            int? idResult = 0;

            try
            {
                var adapter = new QueriesTableAdapter();

                adapter.usp_login(loginForm.usernameTextBox.Text, loginForm.passwordTextBox.Text, ref idResult);

                if (idResult > 0)
                {
                    using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                    {
                        var result = from user in db.Users
                                     where user.user_id == idResult
                                     select user;
                        var userResult = result.FirstOrDefault();

                        if (userResult != null) { }
                        ModelUser newUser = new ModelUser(userResult.user_id, userResult.name, userResult.email,
                                                userResult.phone_number, userResult.balances, userResult.savings);
                        loggedInUser = newUser;
                        Form.ActiveForm.Close();
                        view.usernameLabel.Text = loggedInUser.Name;

                        HomeForm myForm = (HomeForm)curForm;
                        myForm.Close();
                        HomeForm newForm = new HomeForm(view.controller);
                        changeScreen(newForm);
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        #endregion login form controller

        #region main form controller
        public void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(view.controller, view);
            newAddScreen(login);
        }
        public void showHomeScreen()
        {
            HomeForm homeform = new HomeForm(view.controller);
            changeScreen(homeform);
        }
        public void HomeButton_Click(object sender, EventArgs e)
        {
            showHomeScreen();
        }
        public void PortfolioButton_Click(object sender, EventArgs e)
        {
            PortfolioForm portfolioform = new PortfolioForm(view.controller);
            changeScreen(portfolioform);
        }
        public void StatisticButton_Click(object sender, EventArgs e)
        {
            ReportForm statisticform = new ReportForm();
            changeScreen(statisticform);
        }
        public void MoreButton_Click(object sender, EventArgs e)
        {
            MoreForm moreform = new MoreForm(view.controller);
            changeScreen(moreform);
        }
        public void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void minimizeButton_Click(object sender, EventArgs e)
        {
            view.WindowState = FormWindowState.Minimized;
        }

        public void maximizeButton_Click(object sender, EventArgs e)
        {
            if (view.WindowState == FormWindowState.Maximized)
            {
                view.WindowState = FormWindowState.Normal;
            }
            else
            {
                view.WindowState = FormWindowState.Maximized;
            }
            changeScreen(curForm); 
        }
        public void ClearForm()
        {
            foreach (Control ctrl in view.mainPanel.Controls)
            {
                if (ctrl is Form)
                {
                    view.mainPanel.Controls.Remove(ctrl);
                }
            }
        }
        #endregion main form controller

        #region more form controller
        public void kategoriButton_Click(object sender, EventArgs e)
        {
            CategoryForm newForm = new CategoryForm(view.controller);
            changeScreen(newForm);
        }

        public void peopleButton_Click(object sender, EventArgs e)
        {
            PeopleForm newForm = new PeopleForm(view.controller);
            changeScreen(newForm);
        }
        public void excelButton_Click(object sender, EventArgs e)
        {

        }
        #endregion more form controller

        #region home form controller
        public void earningsButton_Click(object sender, EventArgs e)
        {
            AddEarningForm earning = new AddEarningForm(view.controller);
            newAddScreen(earning);
        }

        public void expenseButton_Click(object sender, EventArgs e)
        {
            AddExpenseForm expense = new AddExpenseForm(view.controller);
            newAddScreen(expense);
        }

        public void showButton_Click(object sender, EventArgs e)
        {
            HomeForm myHome = (HomeForm)curForm;
            enableSaldoButton(myHome.akunSaldoTb);

        }
        public void addButton_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = (HomeForm)curForm;
            homeForm.earningsButton.Enabled = true;
            homeForm.expenseButton.Enabled = true;
            homeForm.earningsButton.Visible = true;
            homeForm.expenseButton.Visible = true;
        }
        public void homePanel_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = (HomeForm)curForm;
            homeForm.earningsButton.Enabled = false;
            homeForm.expenseButton.Enabled = false;
            homeForm.earningsButton.Visible = false;
            homeForm.expenseButton.Visible = false;
        }

        public void HomeForm_Load(object sender, EventArgs e)
        {
            HomeForm homeForm = (HomeForm)curForm;
            
            DateTime currentDate = DateTime.Today;

            try
            {
                homeForm.akunSaldoTb.Text = loggedInUser.Balance.ToString();
            } catch(Exception ex)
            {
                homeForm.akunSaldoTb.Text = "0";
            }
            
            try
            {
                object totalExpense;
                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var totalEx = (from expense in db.Expenses
                                   join detail in db.DetailExpenses on expense.expense_id equals detail.expense_id
                                   where expense.user_id == loggedInUser.User_ID
                                         && detail.addedDate.Month == currentDate.Month
                                   select detail.amount).Sum();
                    totalExpense = totalEx;

                }
                homeForm.pengeluaranlabel.Text = totalExpense.ToString();
            }
            catch (Exception ex)
            {
                homeForm.pengeluaranlabel.Text = "0";
            }

            try
            {
                object totalSavings;
                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var totalSav = (from income in db.Incomes
                                    join detail in db.DetailIncomes on income.income_id equals detail.income_id
                                    where income.user_id == loggedInUser.User_ID
                                          && detail.addedDate.Month == currentDate.Month
                                    select detail.amount).Sum();

                    totalSavings = totalSav;
                }
                homeForm.pendapatanLabel.Text = totalSavings.ToString();
            }
            catch (Exception ex)
            {
                homeForm.pendapatanLabel.Text = "0";
            }
        }
            #endregion home form controller

        #region pigetting form controller

        public void addBudgetButton_Click(object sender, EventArgs e)
        {
            AddPigettingForm addPigetting = new AddPigettingForm(view.controller);
            newAddScreen(addPigetting);
        }

        public void PopulatePigetingCategoryComboBox(ComboBox myComboBox)
        {
            string connectionString = Properties.Settings.Default.BudgetingManagementConnectionString;

            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(connectionString))
            {
                if (db.CategoryExpenses != null)
                {
                    var result = from category in db.CategoryExpenses
                                 where category.user_id == loggedInUser.User_ID
                                    select new { category.categoryExpense_name };

                    var data = result.ToList();

                    myComboBox.Items.Clear();

                    foreach (var item in data)
                    {
                        myComboBox.Items.Add(item.categoryExpense_name);
                    }
                }
                else
                {
                    Console.WriteLine("Tabel 'CategoryIncomes' tidak ditemukan dalam DataContext.");
                }
            }
        }

        public void addPigettingButon_Click(object sender, EventArgs e)
        {
            {
                AddPigettingForm addPigettingForm = (AddPigettingForm)Form.ActiveForm;

                int? idResult = 0;
                string chosenCategoryExpense = addPigettingForm.pigettingComboBox.SelectedItem.ToString();
                object resultQuery = 0;


                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var result = from categoryExpense in db.CategoryExpenses
                                 where categoryExpense.user_id == loggedInUser.User_ID && categoryExpense.categoryExpense_name == chosenCategoryExpense
                                 select categoryExpense.categoryExpense_id;
                    resultQuery = result.FirstOrDefault();

                    var adapter = new QueriesTableAdapter();
                    adapter.usp_AddDetailBudget(int.Parse(resultQuery.ToString()), int.Parse(resultQuery.ToString()),
                        double.Parse(addPigettingForm.amountNumericUpDown.Value.ToString()), 
                        ref idResult);
                }

                MessageBox.Show("Budget Record succesfully added");
            }

        }

        //public void PigetingForm_Load(object sender, EventArgs e)
        //{
        //    PigetingForm myForm = (PigetingForm)curForm;
        //    object myResult;

        //    using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
        //    {
        //        var result = (from pigeting in db.viewExpenseBudgets
        //                      where pigeting.user_id == loggedInUser.User_ID
        //                      select new {pigeting.Expense_Category,
        //                      pigeting.Budget, pigeting.Expenses});

        //            myResult = result.ToList();
        //        }
        //        //fillDataGridView(myForm.budgetDataGridView,myResult);
        //}

        public object GetDataFromDatabasePigeting()
        {
            object myResult;

            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
            {
                var result = (from pigeting in db.viewExpenseBudgets
                              where pigeting.user_id == loggedInUser.User_ID
                              select new
                              {
                                  Category = pigeting.Expense_Category,
                                  Budget = pigeting.Budget,
                                  Expense = pigeting.Expenses
                              });

                myResult = result.ToList();
            }
            return myResult;
        }
        #endregion

        #region Category form controller
        public void addCategoryButon_Click(object sender, EventArgs e)
            {
                AddCategories addBudget = new AddCategories(view.controller);
                newAddScreen(addBudget);
            }
            public void addPeopleButon_Click(object sender, EventArgs e)
            {
                AddCategories addBudget = new AddCategories(view.controller);
                newAddScreen(addBudget);
            }

            public void Penghasilanbutton_Click(object sender, EventArgs e)
            {
                CategoryForm category = (CategoryForm)curForm;

                object resultQuery;
                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var result = (from earning in db.CategoryIncomes
                                  where earning.user_id == loggedInUser.User_ID
                                  select new
                                  {
                                      Name = earning.categoryIncome_name
                                  }).ToList();

                    resultQuery = result;
                }

                category.categoryDataGridView.DataSource = resultQuery;
            }

            public void pengeluaranButton_Click(object sender, EventArgs e)
            {
                CategoryForm category = (CategoryForm)curForm;

                object resultQuery;
                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var result = (from earning in db.CategoryExpenses
                                  where earning.user_id == loggedInUser.User_ID
                                  select new
                                  {
                                      Name = earning.categoryExpense_name
                                  }).ToList();

                    resultQuery = result;
                }
                category.categoryDataGridView.DataSource = resultQuery;
            }
            #endregion

        #region portofolio form controller
            public void showSavingsButton_Click(object sender, EventArgs e)
            {
                PortfolioForm myPort = (PortfolioForm)curForm;
                enableSaldoButton(myPort.savingsTextBox);
            }

            public void showTotalButton_Click(object sender, EventArgs e)
            {
                PortfolioForm myPort = (PortfolioForm)curForm;
                enableSaldoButton(myPort.totalTextBox);
            }

            public void showAccountButton_Click(object sender, EventArgs e)
            {
                PortfolioForm myPort = (PortfolioForm)curForm;
                enableSaldoButton(myPort.accountTextBox);
            }
            public void piGetingButton_Click(object sender, EventArgs e)
            {
                PigetingForm pigetting = new PigetingForm(view.controller);
                changeScreen(pigetting);
            }
            public void piGetherButton_Click(object sender, EventArgs e)
            {
                Project_Vispro.View.Pigether pigether = new Project_Vispro.View.Pigether(view.controller);
                changeScreen(pigether);
            }

            public void PortfolioForm_Shown(object sender, EventArgs e)
            {
                PortfolioForm portfolioForm = (PortfolioForm)curForm;
                try
                {
                    portfolioForm.accountTextBox.Text = loggedInUser.Balance.ToString();
                    portfolioForm.savingsTextBox.Text = loggedInUser.Savings.ToString();
                    portfolioForm.totalTextBox.Text = (loggedInUser.Balance + loggedInUser.Savings).ToString();
                }
                catch (Exception ex)
                {
                    portfolioForm.accountTextBox.Text = "0";
                    portfolioForm.savingsTextBox.Text = "0";
                    portfolioForm.totalTextBox.Text = "0";
                }
            }

            public void editSavings_Click(object sender, EventArgs e)
            {
                AddSavingsForm savingsForm = new AddSavingsForm(view.controller);
                newAddScreen(savingsForm);
            }
            public void AddSavingsForm_Shown(object sender, EventArgs e)
            {
                AddSavingsForm savings = (AddSavingsForm)curDialog;

                savings.accountTextBox.Text = loggedInUser.Balance.ToString();
                savings.savingsTextBox.Text = loggedInUser.Savings.ToString();
            }
            #endregion

        #region earning expense form controller
        public void PopulateCategoryEarningComboBox(ComboBox categoryEarningCb)
            {
                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    if (db.CategoryIncomes != null)
                    {
                        var result = from category in db.CategoryIncomes
                                      where category.user_id == loggedInUser.User_ID
                                     select new { category.categoryIncome_name };

                        var data = result.ToList();

                        categoryEarningCb.Items.Clear();
                        foreach (var item in data)
                        {
                            categoryEarningCb.Items.Add(item.categoryIncome_name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tabel 'CategoryIncomes' tidak ditemukan dalam DataContext.");
                    }
                }
            }

            public void PopulateCategoryExpenseComboBox(ComboBox choiceComboBox)
            {
                string connectionString = Properties.Settings.Default.BudgetingManagementConnectionString;

                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(connectionString))
                {
                    if (db.CategoryExpenses != null)
                    {
                        var result = from category in db.CategoryExpenses
                                     where category.user_id == loggedInUser.User_ID
                                     select new { category.categoryExpense_name };

                        var data = result.ToList();

                        choiceComboBox.Items.Clear();

                        foreach (var item in data)
                        {
                            choiceComboBox.Items.Add(item.categoryExpense_name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tabel 'CategoryIncomes' tidak ditemukan dalam DataContext.");
                    }
                }
            }

            public void addExpenseButon_Click(object sender, EventArgs e)
            {
                {
                    AddExpenseForm addExpenseForm = (AddExpenseForm)Form.ActiveForm;

                    int? idResult = 0;
                    string chosenCategoryExpense = addExpenseForm.categoryExpenseComboBox.SelectedItem.ToString();
                    object resultQuery = 0;
                    using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                    {
                        var result = from categoryExpense in db.CategoryExpenses
                                where categoryExpense.user_id == loggedInUser.User_ID && categoryExpense.categoryExpense_name == chosenCategoryExpense
                                select categoryExpense.categoryExpense_id;
                        resultQuery = result.FirstOrDefault(); 

                        var adapter = new QueriesTableAdapter();
                        adapter.usp_AddDetailExpenses(int.Parse(resultQuery.ToString()), double.Parse(addExpenseForm.amountNumericUpDown.Value.ToString()), ref idResult);
                    }
                    renewUserModel();
                    MessageBox.Show("Expense Record succesfully added");
                    HomeForm myForm = (HomeForm)curForm;
                    myForm.Close();
                    HomeForm newForm = new HomeForm(view.controller);
                    changeScreen(newForm);
                }
            }

            public void addEarningButon_Click(object sender, EventArgs e)
            {
                AddEarningForm addIncomeForm = (AddEarningForm)Form.ActiveForm;

                int? idResult = 0;
                string chosenCategoryIncome = addIncomeForm.categoryEarningCb.SelectedItem.ToString();
                object resultQuery = 0;

                using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                {
                    var result = from categoryIncome in db.CategoryIncomes
                                    where categoryIncome.user_id == loggedInUser.User_ID && categoryIncome.categoryIncome_name == chosenCategoryIncome
                                    select categoryIncome.categoryIncome_id;
                    resultQuery = result.FirstOrDefault();

                    var adapter = new QueriesTableAdapter();
                    adapter.usp_AddDetailIncome(int.Parse(resultQuery.ToString()),
                        double.Parse(addIncomeForm.amountNumericUpDown.Value.ToString()),
                        ref idResult);
                    renewUserModel();
                    MessageBox.Show("Earning Record succesfully added");
                    HomeForm myForm = (HomeForm)curForm;
                    myForm.Close();
                    HomeForm newForm = new HomeForm(view.controller);
                    changeScreen(newForm);
                }
        }


        #endregion

        #region pigether form controller

        public object GetDataFromDatabasePigether()
        {
            object myResult;

            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
            {
                var result = (from pigether in db.Pigethers
                              where pigether.user_id == loggedInUser.User_ID
                              select new
                              {
                                  Name = pigether.pigether_name,
                                  Goal = pigether.goal,
                              });

                myResult = result.ToList();
            }
            return myResult;
        }


        public void addPigetherButton_Click(object sender, EventArgs e)
        {
            AddPigetherForm addPigetherForm = new AddPigetherForm(view.controller);
            newAddScreen(addPigetherForm);
        }

        public void addPeoplePigetherButton_Click(object sender, EventArgs e)
        {
            ListPeopleForm addPeople = new ListPeopleForm(view.controller);
            AddPigetherForm myAddPigetherForm = (AddPigetherForm)curDialog;
            newAddScreen(addPeople);
        }

        public void viewDetailButton_Click(object sender, EventArgs e)
        {
            
            View.Pigether myForm = (View.Pigether)curForm;
            
            if (myForm.pigetherDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow pigetherRow = myForm.pigetherDataGridView.SelectedRows[0];
     
                DetailPigetherForm detailPigetherForm = 
                    new DetailPigetherForm(view.controller, 
                    int.Parse((pigetherRow.Cells[0].Value).ToString()));
                newAddScreen(detailPigetherForm);
            }
            else
            {
                MessageBox.Show("You must select a row first!!");
            }
        }
        #endregion

        #region register form controller
            public void registerButton_Click(object sender, EventArgs e)
            {
                RegisterForm registerForm = (RegisterForm)Form.ActiveForm;
                int? idResult = 0;

                try
                {
                    var adapter = new QueriesTableAdapter();

                    adapter.usp_AddUser(registerForm.usernameTextBox.Text, registerForm.passwordTextBox.Text,
                        registerForm.emailTextBox.Text, registerForm.fullnameTextBox.Text,
                        registerForm.phoneNumberTextBox.Text, ref idResult);

                    MessageBox.Show("User Succesfully Added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        #endregion

        #region savings form controller
        public void addSavingsButon_Click(object sender, EventArgs e)
        {
            AddSavingsForm savings = (AddSavingsForm)curDialog;
            if (savings.withdrawSavingsRadioButton.Checked)
            {
                int? idResult = 0;
                var adapter = new QueriesTableAdapter();
                adapter.usp_MoveSavings(loggedInUser.User_ID,float.Parse
                    (savings.amountNumericUpDown.Value.ToString()),ref idResult);
                MessageBox.Show("Balance succesfully added");
            }
            else
            {
                int? idResult = 0;
                var adapter = new QueriesTableAdapter();
                adapter.usp_AddSavings(loggedInUser.User_ID,float.Parse
                    (savings.amountNumericUpDown.Value.ToString()),ref idResult); 
                MessageBox.Show("Savings succesfully added");
            }
            renewUserModel();
            HomeForm myForm = (HomeForm)curForm;
            myForm.Close();
            HomeForm newForm = new HomeForm(view.controller);
            changeScreen(newForm);
        }
        #endregion

        #region add pigether form controller
        public void savePigetherButton_Click(object sender, EventArgs e)
        {
            AddPigetherForm myPigetherForm = (AddPigetherForm)curDialog;
            int? idResult = 0;
            int? detailResult = 0; // Initialize detailResult here
            object pigetherId = null; // Initialize pigetherId to null or appropriate default value

            var adapter = new QueriesTableAdapter();
            adapter.usp_AddPigether(loggedInUser.User_ID.ToString(),myPigetherForm.nameTextBox.Text,
                                    double.Parse(myPigetherForm.pigetterTextBox.Text),ref idResult);

            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
            {
                var result = (from pigether in db.Pigethers
                              where pigether.user_id == loggedInUser.User_ID
                              orderby pigether.pigether_id descending
                              select pigether.pigether_id).FirstOrDefault(); // Use FirstOrDefault to get a single value or default
                pigetherId = result;
            }

            foreach (Model.CategoryPeople people in detailPigetherPeopleList)
            {
                if (double.TryParse(people.Amount.ToString(), out double amount))
                {
                    adapter.usp_AddDetailPigether(int.Parse(pigetherId.ToString()),
                                                  people.CategoryID,
                                                  amount,
                                                  ref detailResult);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            MessageBox.Show("Pigether succesfully added");
            myPigetherForm.Close();
        }
        // detailPigetherPeopleList.Clear(); clear list people after add detail pigether
        #endregion

        #region list people form controller
        public void ListPeopleForm_Load(object sender, EventArgs e)
        {
            ListPeopleForm listPeopleForm = (ListPeopleForm)curDialog;
            
            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))            
            {

                var result = (from people in db.CategoryPeoples
                              where people.user_id == loggedInUser.User_ID
                              select new
                              {
                                  Name = people.people_name
                              });

                peopleList = result.ToList();
                };
            listPeopleForm.categoryPeopleDataGridView.DataSource = peopleList;
        }

        public void addPeopleListButton_Click(object sender, EventArgs e)
        {
            ListPeopleForm listPeopleForm = (ListPeopleForm)curDialog;
            
            if (listPeopleForm.categoryPeopleDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow peopleRow =listPeopleForm.categoryPeopleDataGridView.SelectedRows[0];

                Model.CategoryPeople myPeople = new Model.CategoryPeople
                    (int.Parse(peopleRow.Cells[0].Value.ToString()),
                    peopleRow.Cells[1].Value.ToString()
                    ,float.Parse(listPeopleForm.amountNumericUpDown.Value.ToString()));

                detailPigetherPeopleList.Add(myPeople);
            }
            else
            {
                MessageBox.Show("You must select a row first!!");
            }

            listPeopleForm.Close();

            AddPigetherForm newForm = new AddPigetherForm(view.controller);
            fillDataGridView(newForm.peopleDataGridView,detailPigetherPeopleList);
            newAddScreen(newForm);
        }
        #endregion

        #region detail pigether form controller
        public void DetailPigetherForm_Load(object sender, EventArgs e)
        {
            DetailPigetherForm myform = (DetailPigetherForm)curDialog;
            object data;
            
            using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
            {
                var result = from detail in db.viewDetailPigethers
                             where detail.Pigether_ID == myform.idPigether
                        select detail;
                    data = result.ToList();
                }
            fillDataGridView(myform.peopleDataGridView,data);
            

        }
        #endregion

        #region add category form controller

        public void addBudgetButon_Click(object sender, EventArgs e)
            {
                AddCategories addCategoriesForm = (AddCategories)Form.ActiveForm;

                int? idResult = 0;
                int chosenIndex = addCategoriesForm.typeComboBox.SelectedIndex;


                try
                {
                    var adapter = new QueriesTableAdapter();
                    if (chosenIndex == 0)
                    {
                        adapter.usp_AddCategoryIncome(addCategoriesForm.nameTextBox.Text, loggedInUser.User_ID, ref idResult);
                        using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                        {
                            var result = from categoryIncome in db.CategoryIncomes
                                         where categoryIncome.user_id == loggedInUser.User_ID && categoryIncome.categoryIncome_name == addCategoriesForm.nameTextBox.Text
                                         select categoryIncome.categoryIncome_id;

                            adapter.usp_AddIncome(loggedInUser.User_ID, int.Parse(result.FirstOrDefault().ToString()), ref idResult);
                        }
                    MessageBox.Show("Income category succesfully added");
                    }

                    else if (chosenIndex == 1)
                    {
                        adapter.usp_AddCategoryExpense(loggedInUser.User_ID, addCategoriesForm.nameTextBox.Text, ref idResult);
                        using (BudgetingManagementDBMLDataContext db = new BudgetingManagementDBMLDataContext(Properties.Settings.Default.BudgetingManagementConnectionString))
                        {
                            var result = from categoryExpense in db.CategoryExpenses
                                         where categoryExpense.user_id == loggedInUser.User_ID && categoryExpense.categoryExpense_name == addCategoriesForm.nameTextBox.Text
                                         select categoryExpense.categoryExpense_id;

                            adapter.usp_AddExpenses(loggedInUser.User_ID, int.Parse(result.FirstOrDefault().ToString()), ref idResult);
                        }
                    
                        MessageBox.Show("Expense category succesfully added");
                    }
                    else
                    {
                        adapter.usp_AddPeople(addCategoriesForm.nameTextBox.Text, loggedInUser.User_ID, ref idResult);
                        MessageBox.Show("People category succesfully added");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


        }


    #endregion    
}
 

