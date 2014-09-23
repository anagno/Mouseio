using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Mouseio
{
    public partial class greek_beaches : Form
    {
        private choice parent_form_; //For controlling the parent form

        protected uint beaches_num;
        protected uint beaches_current;

        protected Beach[] beaches;

        public greek_beaches(choice parent_form)
        {
            beaches = new Beach[]
            {
                new Beach("Mύρτος - Κεφαλονιά",Mouseio.Properties.Resources.Myrtos_Kefalonia,"Αυτή η παραλία, βρίσκεται στο βορειοδυτικό τμήμα της Κεφαλονιάς, στην περιοχή της Πυλάρου. Η παραλία βρίσκεται ανάμεσα στους πρόποδες των δύο βουνών, Αγία Δυνατή και Καλόν Όρος. Η Μύρτος είναι παγκοσμίως γνωστή για τις μαγικές αποχρώσεις των χρωμάτων του νερού (του ανοιχτού μπλε, του σκούρου μπλε, του πράσινου-μπλε και του τιρκουάζ) σε αντίθεση με το φωτεινό λευκό των λείων βότσαλων. Το βράδυ, όταν ο ήλιος είναι στον ορίζοντα και καθώς ο ήλιος χάνεται, το νερό είναι χρωματισμένο με υπέροχα χρώματα (κόκκινο, κίτρινο, μωβ, πορτοκαλί). Τα απόκρημνα βουνά και το όμορφο περιβάλλον σχηματίζουν ένα μαγικό και εποβλητικό τοπίο."),
                new Beach("Ναυάγιο - Ζάκυνθος",Mouseio.Properties.Resources.Navagio,"Πρόκειται για έναν απομονωμένο αμμώδη όρμο που βρίσκεται στη βορειοδυτική ακτή του νησιού της Ζακύνθου στο Ιονίο Πέλαγος. Είναι μια από τις πιο διάσημες παραλίες της Ελλάδας και προσελκύει χιλιάδες τουρίστες κάθε χρόνο. Πρόκειται για μια παραλία με λευκή άμμο και καταγάλανα νερά, ενώ περιβάλεται από απόκρημνα βράχια από ασβεστόλιθο. Είναι πολύ γνωστή χάρη στο γεγονός ότι ένα καράβι λαθρεμπόρων, έμεινε ακυβέρνητο και στη συνέχεια προσαράξε στην ακτή. Η όμορφη αυτή παραλία, είναι προσβάσιμη μόνο με καΐκι από το λιμάνι του Πόρτο Βρώμη, του Αγίου Νικολάου Βολιμών ή με κρουαζιερόπλοιο μέσω του γύρου του νησιού."),
                new Beach("Πόρτο Κατσίκι - Λευκάδα",Mouseio.Properties.Resources.portokatsiki,"Η παραλία Πόρτο Κατσίκι, είναι μια πολύ όμορφη παραλία στο νησί του Ιονίου Πελάγους στο νησί της Λευκάδας και είναι μία από τις πιο διάσημες παραλίες στην Ελλάδα αλλά και στην Ευρώπη. Το όνομά της, το πήρε από το γεγόνος οτι παλαιότερα δεν είχε εύκολη πρόσβαση και μόνο κατσίκες μπορούσαν να κατεβούν στην περιοχή. Πρόκειται για μια πολύ διάσημη παραλία, βρίσκεται στο κάτω μέρος ενός ανοιχτου πετρινου τοξου που φαίνεται να έχει καθαρές γραμμές, σαν κάτι που σχεδιάστηκε από αρχιτέκτονα και όχι ένα φυσικό θαύμα. Ορθώνεται από το νερό, σαν σφήνα, στενό στο κέντρο του κόλπου, όπου υπάρχουν μόνο λίγα σκαλοπάτια στην άμμο."),
                new Beach("Βοϊδοκοιλιά - Μεσσηνία",Mouseio.Properties.Resources.Voidokilia_Beach,"Η Βοϊδοκοιλιά είναι παραλία της Μεσσηνίας που θεωρείται από τις ομορφότερες της Μεσογείου. Είναι διάσημη κυρίως για το ολοστρόγγυλο σχήμα της που θυμίζει το γράμμα Ω. Βρίσκεται βόρεια της Πύλου, στις ακτές του Ιονίου, και εφάπτεται με τη λιμνοθάλασσα της Γιάλοβας από την οποία χωρίζεται με μία λωρίδα αμμόλοφων. Η παραλία και η ευρύτερη περιοχή έχει χαρακτηριστεί τόπος ιδιαίτερου φυσικού κάλλους και είναι ενταγμένη στο Δίκτυο Natura 2000.Η παραλία προσεγγίζεται από χωματόδρομο που διασχίζει περιμετρικά την λιμνοθάλασσα της Γιάλοβας, από χωματόδρομο από το χωριό Πετροχώρι καθώς και από μονοπάτι από την παραλία Διβάρι."),
                new Beach("Ψαρού - Μύκονος",Mouseio.Properties.Resources.psarou,"Είναι ένα από τα πιο γνωστά χωριά παραλία της Μυκόνου, αλλά κυρίως μεταξύ των Ελλήνων. Κάθε χρόνο, χιλιάδες τουρίστες και διασημότητες επισκέπτονται αυτή την αμμώδη παραλία, η οποία είναι οργανωμένη και προσφέρει πολυτελείς ξαπλώστρες και ομπρέλες. Λόγω της δημοτικότητας της Ψαρού, ειδικά κατά τη διάρκεια του Αυγούστου, που αποτελεί το αποκορύφωμα της υψηλής σεζόν, υπάρχει μια λίστα αναμονής για τις ξαπλώστρες και ομπρέλες. Αυτή η κοσμοπολίτικη παραλία περιβάλλεται από φανταχτερά εστιατόρια, ταβέρνες, μίνι μάρκετ. Πολλά πολυτελή ξενοδοχεία και χτίστηκε γύρω από την Ψαρού. Βρίσκεται 4 χλμ. από την πόλη της Μυκόνου (ή Χώρα) και είναι κοντά στο Πλατύ Γιαλό."),
                new Beach("Κόκκινη Παραλία - Σαντορίνη", Mouseio.Properties.Resources.Red_beach,"Κόκκινη Παραλία είναι μια από τις πιο δημοφιλείς και όμορφες παραλίες της Σαντορίνης. Αυτή η μοναδική παραλία βρίσκεται στη Δυτική πλευρά του νησιού, δίπλα στον αρχαιολογικό χώρο του Ακρωτηρίου. Τα κόκκινα βράχια από λάβα γύρω από μια μικρή παραλία με κόκκινα και μαύρα βότσαλα και την καταγάλανη θάλασσα, συνθέτουν μια εικόνα σπάνιας ομορφιάς. Τα πρώτα μέτρα στο νερό της θάλασσας είναι κυρίως αμμώδη, ωστόσο υπάρχουν και αρκετές πέτρες.  Για να επισκεφθείτε την Κόκκινη Παραλία, ακολουθήστε το δρόμο προς το Ακρωτήρι και αναζητήστε τη ταμπέλα προς την Κόκκινη παραλία. Ο δρόμος θα σας οδηγήσει στο Ακρωτήρι, εκεί θα βρείτε ένα μικρό εκκλησάκι και χώρο στάθμευσης όπου αφήνετε το όχημα σας εκεί και συνεχίζετε με τα πόδια για περίπου 10 λεπτά κατηφορίζοντας από ένα μονοπάτι. Ένας άλλος τρόπος για να επισκεφθείτε την ιδιαίτερη αυτή παραλία, είναι να πάρετε ένα από τα μικρά σκάφη από την Περίσσα ή το Ακρωτήρι.")
            };

            InitializeComponent();
            parent_form_ = parent_form;
            initiliazeBeach();
        }

        protected void initiliazeBeach()
        {
            beaches_current = 0;
            beaches_num = (uint) beaches.GetLength(0);
            pictureBox.Image = beaches[0].getImage();
            textBox.Text = beaches[0].getDescription();
            label.Text = beaches[0].getName();
            labelNum.Text = (beaches_current + 1) + "/" + beaches_num;
            buttonPrevious.Enabled = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                parent_form_.Location = this.Location;
            }
            catch (InvalidCastException exception)
            {

            }
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            --beaches_current;
            pictureBox.Image = beaches[beaches_current].getImage();
            textBox.Text = beaches[beaches_current].getDescription();
            label.Text = beaches[beaches_current].getName();
            labelNum.Text = (beaches_current + 1) + "/" + beaches_num;

            if (beaches_current == 0)
            {
                buttonPrevious.Enabled = false;
            }

            if (beaches_current < beaches_num)
            {
                buttonNext.Enabled = true;
            }

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            ++beaches_current;
            pictureBox.Image = beaches[beaches_current].getImage();
            textBox.Text = beaches[beaches_current].getDescription();
            label.Text = beaches[beaches_current].getName();
            labelNum.Text = (beaches_current + 1) + "/" + beaches_num;
            
            if( (beaches_current+1) == beaches_num)
            {
                buttonNext.Enabled = false;
            }

            if(beaches_current>0)
            {
                buttonPrevious.Enabled = true;
            }
        }


        private void ToolStripMenuItemSaveText_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialogText.ShowDialog())
            {
                string beach_string = textBox.Text;
                using (StreamWriter beach_file = new StreamWriter(File.Create(saveFileDialogText.FileName)))
                {
                    beach_file.Write(beach_string);
                }

            }
        }

        private void ToolStripMenuItemSaveImage_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == saveFileDialogImage.ShowDialog())
            {
                pictureBox.Image.Save(saveFileDialogImage.FileName);
            }
            
        }
    }
}
