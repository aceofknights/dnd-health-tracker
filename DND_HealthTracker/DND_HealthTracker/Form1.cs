namespace DND_HealthTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int health;
        int damage;
        int updateHealth;

        private int UpdateHealth(TextBox textBox, int damageValue, bool isAdding)
        {
            string text = textBox.Text;
            if (int.TryParse(text, out int currentHealth))
            {
                if (isAdding)
                {
                    currentHealth += damageValue;
                }
                else
                {
                    currentHealth -= damageValue;
                }

                textBox.Text = currentHealth.ToString();
                return currentHealth;
            }
            return -1; // or any other value to indicate an error
        }


        private void btnPlusR1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusR1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusR2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR2, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusR2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR2, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusR3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR3, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusR3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR3, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusR4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR4, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusR4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR4, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusR5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR5, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusR5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxR5, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusB1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusB1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusB2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB2, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusB2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB2, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusB3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB3, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusB3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB3, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusB4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB4, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusB4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB4, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusB5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB5, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusB5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxB5, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusG1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusG1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusG2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG2, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusG2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG2, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusG3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG3, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusG3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG3, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusG4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG4, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusG4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG4, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusG5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG5, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusG5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxG5, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusY1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusY1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusY2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY2, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusY2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY2, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusY3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY3, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusY3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY3, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusY4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY4, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusY4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY4, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusY5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY5, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusY5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxY5, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusW1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusW1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusW2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW2, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusW2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW2, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusW3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW3, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusW3_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW3, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusW4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW4, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusW4_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW4, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusW5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW5, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusW5_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxW5, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnPlusCustom1_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxCustom1, damageValue, isAdding: true);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }

        private void btnMinusCustom2_Click(object sender, EventArgs e)
        {
            string dmg = textBoxDamage.Text;
            if (int.TryParse(dmg, out int damageValue))
            {
                int updatedHealth = UpdateHealth(textBoxCustom1, damageValue, isAdding: false);
                if (updatedHealth == -1)
                {
                    MessageBox.Show("Health needs to be an integer");
                    textBoxDamage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Damage needs to be an integer");
                textBoxDamage.Clear();
            }
        }
    }
}
