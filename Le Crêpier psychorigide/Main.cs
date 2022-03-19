using MoreLinq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Le_Crêpier_psychorigide
{
    public partial class Main : Form
    {
        private Random rdn = new Random();
        private int actualStep = 0;
        private int maxStep;
        private List<Step> solveStep = new List<Step>();
        private List<string> positionCrepeDepart = new List<string>();
        private List<Panel> actualCrepe = new List<Panel>();
        private List<string> positionCrepe = new List<string>();
        private int Crepe_height = 25;
        private int temp = -1;
        int essaiActuel = 0;
        int totalCrêpeGénérées = 0;

        public Main()
        {
            InitializeComponent();
            Icon = Le_Crêpier_psychorigide.Properties.Resources.icon;
        }

        private void textBox_nbCrêpe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Textbox qui n'autorise que les nombres
                List<char> lettresInTexteBox_nbCrêpe = textBox_nbCrêpe.Text.ToList();
                for (int i = 0; i < lettresInTexteBox_nbCrêpe.Count; i++)
                {
                    if (Regex.IsMatch(Char.ToString(lettresInTexteBox_nbCrêpe[i]), "[^0-9]"))
                    {
                        textBox_nbCrêpe.Text = textBox_nbCrêpe.Text.Remove(i, i + 1);
                        textBox_nbCrêpe.SelectionStart = textBox_nbCrêpe.Text.Length;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Génère une pile de crêpe mélangé
        /// </summary>
        private void button_generate_Click(object sender, EventArgs e)
        {
            clearCrepes(true);
            ActiveControl = pictureBox_next;

            actualStep = 0;
            maxStep = 0;
            List<Panel> crepes = new List<Panel>();
            int Crepe_nb = 0;
            Point location = new Point(3, 582);
            positionCrepe.Clear();
            actualCrepe.Clear();
            positionCrepe.Clear();

            try
            {
                Crepe_nb = Convert.ToInt32(textBox_nbCrêpe.Text);
            }
            catch { }

            // Change la  taille pour que ça reste dans le champ de vision
            if (Crepe_nb > 24 && Crepe_nb < 39)
            {
                Crepe_height = 15;
            }
            else if (Crepe_nb > 23 && Crepe_nb <= 44)
            {
                Crepe_height = 13;
            }
            else if (Crepe_nb > 44 && Crepe_nb <= 53)
            {
                Crepe_height = 11;
            }
            else if (Crepe_nb > 53 && Crepe_nb < 71)
            {
                Crepe_height = 8;
            }
            else
            {
                Crepe_height = 25;
            }

            int Crepe_width = 732;

            // Limite de crêpe
            if (Crepe_nb < 71 && Crepe_nb > 0)
            {
                totalCrêpeGénérées += Crepe_nb;
                label_nbCrepeGénéré.Text = totalCrêpeGénérées + " générée(s) au total";

                for (int i = Crepe_nb; i > 0; i--)
                {
                    if (Crepe_nb <= 14)
                    {
                        Crepe_width -= 50;
                    }
                    else if (Crepe_nb <= 30)
                    {
                        Crepe_width -= 24;
                    }
                    else if (Crepe_nb <= 50)
                    {
                        Crepe_width -= 14;
                    }
                    else if (Crepe_nb <= 70)
                    {
                        Crepe_width -= 10;
                    }

                    // Génère une crêpe aléatoirement
                    Panel crepe = new Panel();
                    crepe.BorderStyle = BorderStyle.FixedSingle;
                    crepe.BackColor = ControlPaint.LightLight(Color.FromArgb(rdn.Next(0, 255), rdn.Next(0, 255), rdn.Next(0, 255)));
                    crepe.Height = Crepe_height;
                    crepe.Size = new Size(Crepe_width, Crepe_height);
                    crepe.Location = location;
                    crepe.Name = i.ToString(); // Nombre de la crêpe | la < petite = 1
                    crepe.Left = (panel_crepe.Width - crepe.Width) / 2;

                    // Est-ce que ma crêpes est dans le bon sens ?
                    // True = face cramé vers le bas, donc oui
                    // False = face cramé vers le haut
                    int prob = rdn.Next(100);
                    crepe.Enabled = prob <= 50;

                    // Génère la partie pas cuite
                    Panel cramé = new Panel();
                    cramé.BorderStyle = BorderStyle.None;
                    cramé.BackColor = ControlPaint.Dark(crepe.BackColor);
                    cramé.Size = new Size(Crepe_width - 20, Crepe_height / 4);

                    // Position de la crêpe en fonction de si elle est au bonne endroit
                    if (crepe.Enabled)
                    {
                        cramé.Location = new Point((crepe.Width - cramé.Width) / 2, crepe.Height - cramé.Height);
                    }
                    else
                    {
                        cramé.Location = new Point((crepe.Width - cramé.Width) / 2, 0);
                    }

                    cramé.Visible = !radioButton_alg0.Checked;
                    crepe.Controls.Add(cramé);

                    Label label = new Label();
                    label.Text = crepe.Name;

                    // Change la taille du label si le nombre est trop grand
                    if (Crepe_nb > 24 && Crepe_nb < 39)
                    {
                        label.Font = new Font("Arial", 8, FontStyle.Regular);
                    }
                    else if (Crepe_nb > 23 && Crepe_nb < 48)
                    {
                        label.Font = new Font("Arial", 6, FontStyle.Regular);
                    }
                    else if (Crepe_nb > 47 && Crepe_nb < 71)
                    {
                        label.Font = new Font("Arial", 4, FontStyle.Regular);
                    }
                    else
                    {
                        label.Font = new Font("Arial", 12, FontStyle.Bold);
                    }

                    crepe.Controls.Add(label);

                    // L'ajoute dans la liste de crêpe
                    crepes.Add(crepe);

                    // Augmente les positions des crêpes pour que la prochaine soit centrer sur la première
                    location.Y -= Crepe_height;
                    location.X += 5;
                }

                // Liste contenant la location de toutes les crêpes
                List<Point> locationCrepe = new List<Point>();

                // On ajoute la location de chaques crêpes
                foreach (var crepe in crepes)
                {
                    locationCrepe.Add(crepe.Location);
                }

                // Set les locations de base
                for (int i = 0; i < crepes.Count; i++)
                {
                    locationCrepe.Add(crepes[i].Location);
                }

                // On mélange les crêpes
                crepes = crepes.OrderBy(a => Guid.NewGuid()).ToList();

                // On attribut les même location aux crêpes mélangé
                for (int i = 0; i < crepes.Count; i++)
                {
                    crepes[i].Location = new Point(crepes[i].Location.X, locationCrepe[i].Y);
                }

                // Affiche les crêpes
                foreach (var crepe in crepes)
                {
                    panel_crepe.Controls.Add(crepe);
                }

                // Alghortime
                // Récupère la position de chaque crêpe actuelle en nombre et en panel
                foreach (Panel crepe in panel_crepe.Controls)
                {
                    if (crepe.Visible == true)
                    {
                        positionCrepeDepart.Add(crepe.Name + "," + crepe.Enabled);
                        positionCrepe.Add(crepe.Name + "," + crepe.Enabled);
                        actualCrepe.Add(crepe);
                    }
                }

                positionCrepe.Reverse();

                // Affiche l'ordre des crêpes dans le label info
                string info = null;
                foreach (var pos in positionCrepe)
                {
                    info += pos + " - ";
                }
                info = info.Remove(info.Length - 2);

                label_info.Text = info;

                actualCrepe.Reverse();

                try
                {
                    solveStep.Clear();
                }
                catch
                {
                }

                solveStep = ranger(positionCrepe);
                solveStep[0].StepL = positionCrepeDepart;

                if(solveStep == null)
                {
                    button_generate_Click(this, null);
                }

                try
                {
                    int essaiMax = 150;

                    if (!String.IsNullOrEmpty(textBox_nbEtape.Text))
                    {
                        if (solveStep.Count != Convert.ToInt32(textBox_nbEtape.Text) + 1 && essaiMax != essaiActuel)
                        {
                            essaiActuel++;
                            label_nbEssai.Text = essaiActuel.ToString() + " essai(s)";
                            button_generate_Click(this, null);
                        }

                        if (essaiMax == essaiActuel)
                        {
                            textBox_nbEtape.Text = string.Empty;
                            essaiActuel = 0;
                            MessageBox.Show("Aucune des " + essaiMax + " piles aléatoires générées ne corresponde à votre nombre d'étape. Merci de réessayer.",
                                "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                { }

                essaiActuel = 0;

                if (radioButton_alg2.Checked)
                {
                    try
                    {
                        solveStep = solveStep.DistinctBy(x => x.StepL).ToList();
                    }
                    catch
                    {
                    }

                    try
                    {
                        // est ce que le dernier step est faux
                        foreach (var s in solveStep[solveStep.Count - 1].StepL)
                        {
                            string[] inf = s.Split(',');
                            if (!Convert.ToBoolean(inf[1]))
                            {
                                button_generate.PerformClick();
                                return;
                            }
                        }
                    }
                    catch
                    { }
                }

                try
                {
                    panel_step.Visible = true;
                    maxStep = solveStep.Count - 1;
                }
                catch
                { }
                label_step.Text = actualStep + "/" + maxStep;
            }
            else
            {
                // Si il y a plus de 70 crêpes
                MessageBox.Show("Vous ne pouvez générer qu'au maximum 70 crêpes et doit être supérieur à 0 !", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                panel_step.Visible = false;
            }
        }

        public string returnIntValue(string t)
        {
            string[] a = t.Split(',');
            return a[0];
        }

        /// <summary>
        /// Algorithme
        /// </summary>
        /// <param name="positionCrepe"></param>
        /// Prend la crêpes la plus grande, la met en haut et retourne toute la pile sauf les dernières bien placé
        /// <returns>Liste d'étape </returns>
        private List<Step> ranger(List<string> positionCrepeA)
        {
            try
            {
                List<string> positionCrepe = positionCrepeA;

                List<Step> solveStep = new List<Step>();

                solveStep.Add(new Step(positionCrepeA));

                if (radioButton_alg0.Checked)
                {
                    int nbToSearch = positionCrepe.Count;
                    int nb = 1;
                    for (int i = 0; i < positionCrepe.Count; i++)
                    {
                        // Cherche l'index du nombre à trouver (10, 9 puis 8... si le chiffre entrée est 10)
                        int indexOfMaxToSearch;
                        try
                        {
                            indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",True");

                            if (indexOfMaxToSearch == -1)
                            {
                                indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",False");
                            }
                        }
                        catch
                        {
                            indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",False");
                        }

                        // Si la dernière position n'est pas déjà égal au nombre que l'on cherche
                        if (positionCrepe[indexOfMaxToSearch] != positionCrepe[positionCrepe.Count - nb])
                        {
                            // Si la première position n'est pas déjà égal au nombre que l'on cherche
                            if (positionCrepe[indexOfMaxToSearch] != positionCrepe[0])
                            {
                                // Retourne la pile
                                positionCrepe.Reverse(0, indexOfMaxToSearch + 1);

                                string[] tempA = positionCrepe.ToArray();
                                solveStep.Add(new Step(tempA.Reverse().ToList()));
                            }

                            // La re-retourne pour avoir le chiffre en bas
                            positionCrepe.Reverse(0, nbToSearch);

                            string[] temp = positionCrepe.ToArray();
                            solveStep.Add(new Step(temp.Reverse().ToList()));
                        }
                        nbToSearch--;
                        nb++;
                    }
                }
                else if (radioButton_alg2.Checked)
                {
                    // Même algorithme mais avec un paramètre en plus;
                    int nbToSearch = positionCrepe.Count;
                    int nb = 1;
                    for (int i = 0; i < positionCrepe.Count; i++)
                    {
                        // Cherche l'index du nombre à trouver (10, 9 puis 8... si le chiffre entrée est 10)
                        int indexOfMaxToSearch;
                        try
                        {
                            indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",True");

                            if (indexOfMaxToSearch == -1)
                            {
                                indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",False");
                            }
                        }
                        catch
                        {
                            indexOfMaxToSearch = positionCrepe.IndexOf(nbToSearch.ToString() + ",False");
                        }

                        // Si la dernière position n'est pas déjà égal au nombre que l'on cherche
                        if (positionCrepe[indexOfMaxToSearch] != positionCrepe[positionCrepe.Count - nb])
                        {
                            // Si la première position n'est pas déjà égal au nombre que l'on cherche
                            if (positionCrepe[indexOfMaxToSearch] != positionCrepe[0])
                            {
                                // Retourne la pile
                                // On retournes les crêpes
                                for (int a = 0; a < indexOfMaxToSearch + 1; a++)
                                {
                                    string[] oo = positionCrepe[a].Split(',');
                                    if (oo[1].Equals("True"))
                                    {
                                        oo[1] = "False";
                                    }
                                    else
                                    {
                                        oo[1] = "True";
                                    }

                                    positionCrepe[a] = String.Join(",", oo);
                                }
                                positionCrepe.Reverse(0, indexOfMaxToSearch + 1);

                                string[] tempA = positionCrepe.ToArray();
                                solveStep.Add(new Step(tempA.Reverse().ToList()));
                            }

                            // Si la crêpe du dessus à pas ça face au bonne endroit
                            string[] arr = solveStep[0].StepL[0].Split(',');
                            if (Convert.ToBoolean(arr[1]))
                            {
                                // On la met au bonne endroit
                                positionCrepe[0] = arr[0] + ",False";

                                string[] tempA = positionCrepe.ToArray();
                                solveStep.Add(new Step(tempA.Reverse().ToList()));
                            }

                            // On retournes les crêpes
                            for (int a = 0; a < nbToSearch; a++)
                            {
                                string[] oo = positionCrepe[a].Split(',');
                                if (oo[1].Equals("True"))
                                {
                                    oo[1] = "False";
                                }
                                else
                                {
                                    oo[1] = "True";
                                }

                                positionCrepe[a] = String.Join(",", oo);
                            }
                            // La re-retourne pour avoir le chiffre en bas
                            positionCrepe.Reverse(0, nbToSearch);

                            string[] temp = positionCrepe.ToArray();
                            solveStep.Add(new Step(temp.Reverse().ToList()));
                        }
                        else
                        {
                            // Si la dernière position n'est pas dans le bon ordre de coté
                            string[] arr = positionCrepe[positionCrepe.Count - nb].Split(',');
                            if (!Convert.ToBoolean(arr[1]))
                            {
                                // On retournes les crêpes
                                for (int a = 0; a < indexOfMaxToSearch + 1; a++)
                                {
                                    string[] oo = positionCrepe[a].Split(',');
                                    if (oo[1].Equals("True"))
                                    {
                                        oo[1] = "False";
                                    }
                                    else
                                    {
                                        oo[1] = "True";
                                    }

                                    positionCrepe[a] = String.Join(",", oo);
                                }
                                // Retourne la pile
                                positionCrepe.Reverse(0, indexOfMaxToSearch + 1);

                                string[] tempA = positionCrepe.ToArray();
                                solveStep.Add(new Step(tempA.Reverse().ToList()));

                                // Retourne la crêpe du dessus
                                positionCrepe[0] = arr[0] + ",False";

                                string[] tempX = positionCrepe.ToArray();
                                solveStep.Add(new Step(tempX.Reverse().ToList()));

                                // On retournes les crêpes
                                for (int a = 0; a < nbToSearch + 1; a++)
                                {
                                    string[] oo = positionCrepe[a].Split(',');
                                    if (oo[1].Equals("True"))
                                    {
                                        oo[1] = "False";
                                    }
                                    else
                                    {
                                        oo[1] = "True";
                                    }

                                    positionCrepe[a] = String.Join(",", oo);
                                }
                                // La re-retourne pour avoir le chiffre en bas
                                positionCrepe.Reverse(0, nbToSearch);

                                string[] temp = positionCrepe.ToArray();
                                solveStep.Add(new Step(temp.Reverse().ToList()));
                            }
                        }

                        nbToSearch--;
                        nb++;
                    }
                }

                return solveStep;
            }
            catch
            {
                button_generate.PerformClick();
                return null;
            }
        }

        private void clearCrepes(bool completeClearing = false)
        {
            // Supprimer toutes les crêpes existantes dans le panel
            List<Control> todelete = new List<Control>();
            foreach (Control crepe in panel_crepe.Controls)
            {
                if (!(crepe is Label))
                {
                    if (completeClearing)
                    {
                        todelete.Add(crepe);
                    }
                    else
                    {
                        crepe.Visible = false;
                    }
                }
            }

            if (completeClearing)
            {
                foreach (var todelet in todelete)
                {
                    panel_crepe.Controls.Remove(todelet);
                }
            }
        }

        private void pictureBox_next_Click(object sender, EventArgs e)
        {
        }

        private void showInfoStep(int step)
        {
            // Affiche l'ordre des crêpes dans le label info
            string[] temp = solveStep[step].StepL.ToArray();
            Array.Reverse(temp);

            label_info.Text = string.Join(" - ", temp);
        }

        private void textBox_nbCrêpe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button_generate.PerformClick();
            }
        }

        private void Main_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox_next_Click(this, null);
            }
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                label_nbEtape.Visible = true;
                textBox_nbEtape.Visible = true;
            }
        }

        private void pictureBox_next_MouseDown(object sender, MouseEventArgs e)
        {
            if (actualStep != maxStep)
            {
                try
                {
                    actualStep++;
                    label_step.Text = actualStep + "/" + maxStep;

                    // Montre le step suivant
                    if (temp != actualStep)
                    {
                        temp = actualStep;
                    }

                    Point location = new Point(3, 582);

                    for (int i = 0; i < solveStep[actualStep].StepL.Count; i++)
                    {

                        for (int z = 0; z < actualCrepe.Count; z++)
                        {
                            if(actualCrepe[z].Visible)
                            {
                                // Si le premier nombre du step et bien celui ci, alors on l'affiche
                                if (returnIntValue(solveStep[actualStep].StepL[i]).Equals(actualCrepe[z].Name))
                                {
                                    string[] arr = solveStep[actualStep].StepL[i].Split(',');
                                    actualCrepe[z].Enabled = Convert.ToBoolean(arr[1]);

                                    foreach (Control ctrl in actualCrepe[z].Controls)
                                    {
                                        if (ctrl is Panel)
                                        {
                                            // Position de la crêpe en fonction de si elle est au bonne endroit
                                            if (actualCrepe[z].Enabled)
                                            {
                                                ctrl.Location = new Point((actualCrepe[z].Width - ctrl.Width) / 2, actualCrepe[z].Height - ctrl.Height);
                                            }
                                            else
                                            {
                                                ctrl.Location = new Point((actualCrepe[z].Width - ctrl.Width) / 2, 0);
                                            }
                                        }
                                    }


                                    actualCrepe[z].Location = location;

                                    // Centre la crêpe dans le panel
                                    actualCrepe[z].Left = (panel_crepe.Width - actualCrepe[z].Width) / 2;

                                    // Augmente les positions des crêpes pour que la prochaine soit centrer sur la première
                                    location.Y -= Crepe_height;
                                }
                            }
                        }
                    }

                    // Affiche l'ordre des crêpes dans le label info
                    showInfoStep(actualStep);
                }
                catch { }
            }
        }

        private void label_step_DoubleClick(object sender, EventArgs e)
        {
            label_step.Visible = false;
            textBox_setState.Visible = true;
            ActiveControl = textBox_setState;
        }

        private void textBox_setState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_setState.Visible = false;
                try
                {
                    if (temp != Convert.ToInt32(textBox_setState.Text) + 1)
                    {
                        actualStep = Convert.ToInt32(textBox_setState.Text);
                        actualStep--;

                        if (actualStep == -1)
                        {
                            actualStep = 0;
                        }

                        if (actualStep > maxStep)
                        {
                            actualStep = maxStep - 1;
                        }

                        if (actualStep < 0)
                        {
                            actualStep = 1;
                        }

                        pictureBox_next_MouseDown(this, null);
                    }
                }
                catch { }
                label_step.Visible = true;
            }
        }

        private void textBox_setState_Leave(object sender, EventArgs e)
        {
            label_step.Visible = true;
            textBox_setState.Visible = false;
        }

        /// <summary>
        /// Affiche/Enlève la partie cramé des crêpes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_alg2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Etape précédente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_prev_MouseDown(object sender, MouseEventArgs e)
        {
            if(actualStep != 0)
            {
                actualStep-=2;
                pictureBox_next_MouseDown(this, null);
            }
        }
    }
}