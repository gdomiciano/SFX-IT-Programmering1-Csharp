using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hänga_Gubbe
{
    public partial class Spel : Form
    {
        public Spel()
        {
            InitializeComponent();
        }
       /// <summary>
       /// Variabler ledig för hela programmet
       /// </summary>
        public int fel = 5;
        public string bildMapp = Directory.GetCurrentDirectory() + "\\bilder\\";

        /// <summary>
        /// Återställa elementens egenskaperna innan programmet har rätt ord
        /// </summary>
        public void ÅterställaSpel()
        {
            pbxGubbe.Visible = false;
            pbxGubbe.Top = 72;
            pbxGubbe.Image = Image.FromFile(bildMapp + "5.ico");
            pbxMark.Visible = false;
            tbxVisa.Visible = false;
            tbxGissa.Visible = false;
            lblInfo.Text = "";
            tbxVisa.Text = "";
            mTbxSvar.Text = "";
            tbxGissa.Enabled = false;
            mTbxSvar.Enabled = true;
            btnSlumpa.Enabled = true;
            mTbxSvar.Focus();
            fel = 5;
        }
        /// <summary>
        /// Aktivera elementens egenskaperna efter programmet har rätt ord
        /// </summary>
        private void AktiveraSpel()
        {
            
            lblInfo.Text = "Gissa på en bokstav";
            tbxVisa.Text = "??????";
            pbxGubbe.Visible = true;
            pbxMark.Visible = true;
            tbxVisa.Visible = true;
            tbxGissa.Visible = true;
            mTbxSvar.Enabled = false;
            btnSlumpa.Enabled = false;
            tbxGissa.Enabled = true;
            tbxGissa.Focus();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spel_Load(object sender, EventArgs e)
        {
            ÅterställaSpel();
        }

        /// <summary>
        /// Addera gräss till miljö
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbxMark_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.DarkGreen);

            g.FillRectangle(brush, -1, 290, 350, 50);
        }

        /// <summary>
        /// validera om spel är redo grundad på ordslängd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MTbxSvar_KeyUp(object sender, KeyEventArgs e)
        {
            if (mTbxSvar.Text.Length == 6) AktiveraSpel();
        }

        /// <summary>
        /// Aktivera spel grundad på slumpmässigt skapade ord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSlumpa_Click(object sender, EventArgs e)
        {
            Random ordIndex = new Random();
            List<string> ordList = new List<string>();
            ordList.AddRange(collection: new string[] { "abnorm", "abrupt", "absurd", "accent", "aceton", "ackord", "action", "adress", "advent", "affekt", "agerar", "aktion", "aktris", "aktsam", "akuten", "aladåb", "albino", "aldrig", "alkemi", "allena", "allmän", "alltid", "alltså", "allvar", "alster", "altare", "amason", "amatör", "amiral", "amning", "ampere", "ampull", "anabol", "analog", "analys", "ananas", "anarki", "andakt", "andlig", "andlös", "andnöd", "andrar", "andrum", "anfall", "anfang", "anföll", "angett", "angick", "angrep", "anhalt", "anhöll", "ankare", "ankrar", "anlete", "annars", "annons", "anonym", "anorak", "ansats", "ansedd", "anslag", "anslår", "anstår", "anstöt", "ansvar", "antenn", "apotek", "appell", "applåd", "apport", "apropå", "arbete", "arrest", "artist", "arvlös", "arvode", "asbest", "asfalt", "asjett", "askfat", "aspekt", "ateist", "ateljé", "attack", "attest", "avbild", "avbröt", "avdrag", "avfall", "avfart", "avfärd", "avgick", "avgift", "avgång", "avhopp", "avkall", "avkrok", "avlade", "avlagt", "avlopp", "avlång", "avmätt", "avresa", "avsats", "avsikt", "avsked", "avskum", "avskyr", "avslag", "avslog", "avslår", "avsmak", "avsteg", "avstyr", "avstår", "azalea", "babord", "bacill", "backar", "baddar", "badkar", "badort", "badrum", "bagage", "bagare", "bageri", "bagett", "bajsar", "baklås", "bakrus", "balans", "balett", "ballad", "balsam", "bandar", "bandit", "bankar", "bankir", "bannor", "bantar", "barack", "barkis", "barock", "basker", "basket", "bastar", "batalj", "batist", "batong", "baxnar", "bebodd", "bedrar", "bedrog", "beduin", "befann", "begett", "begrep", "behåll", "behöll", "bekant", "bekväm", "belopp", "belägg", "beläst", "bensin", "beredd", "berest", "bergig", "bergis", "berått", "berömd", "besatt", "besked", "beskär", "beslag", "beslut", "beslår", "beslöt", "bestod", "bestyr", "består", "besvär", "beting", "betong", "betsar", "betsel", "bevars", "bevänt", "bidrag", "bidrar", "bifall", "bigami", "bigott", "bihang", "bihåla", "bikini", "biktar", "bilaga", "bildad", "bildar", "bilism", "bilist", "biljon", "billig", "bindel", "binder", "biolog", "bisarr", "bisats", "biskop", "bismak", "bister", "bistro", "bistår", "bitter", "bitvis", "bjuder", "bjälke", "bjässe", "blanko", "blankt", "blaska", "blazer", "bleker", "bliver", "blivit", "blodig", "blomma", "blotta", "blåbär", "blågul", "blånar", "blåser", "blåsig", "blåögd", "blöder", "blödig", "boaorm", "bockar", "bofast", "bofink", "bokför", "bollar", "bolmar", "bombar", "bommar", "bomull", "bondsk", "boning", "bordar", "borgar", "borgen", "borrar", "borste", "bortom", "bortre", "bortåt", "bosatt", "boskap", "bostad", "botten", "bovete", "boxare", "bracka", "brakar", "bralla", "bravad", "blöter", "bravur", "breder", "bricka", "bridge", "brigad", "bringa", "broder", "brokig", "brorsa", "brosch", "brukar", "brunch", "brunst", "brusar", "brutal", "bruten", "brutit", "brutto", "brygga", "bryner", "bryter", "brådis", "bråkar", "bråkig", "bräckt", "bräker", "bränns", "bräsch", "brätte", "bubbla", "buckla", "budget", "bukett", "buktar", "buktig", "bulgar", "buller", "bulnad", "bultar", "bulvan", "bundit", "bunker", "buntar", "burdus", "burgen", "buskis", "bussar", "bussig", "butelj", "butter", "bygger", "byling", "bågfil", "bågnar", "bårhus", "bäcken", "bäddar", "bägare", "bänder", "bärare", "bärgar", "bäring", "bästis", "bättre", "böjlig", "böljar", "bönhus", "bönhör", "bördig", "början", "börjar", "campar", "cancer", "capita", "cement", "censur", "center", "cesium", "charad", "chassi", "chilen", "chimär", "cigarr", "cirkel", "cirkus", "citron", "collie", "cowboy", "cyklar", "cynisk", "cynism", "daddar", "dagbok", "daghem", "daglig", "dagtid", "daller", "daltar", "damast", "dammar", "dammig", "damrum", "dansar", "danska", "dansör", "darrar", "darrig", "debatt", "defekt", "delfin", "delger", "deltar", "deltid", "deltog", "delvis", "deppad", "deppar", "deppig", "design", "despot", "detalj", "diadem", "dialog", "diarré", "diesel", "diffus", "diggar", "dignar", "diktar", "diktat", "dillar", "dimmig", "dimper", "diplom", "dippar", "direkt", "diskar", "diskho", "diskus", "dispyt", "disträ", "djäkel", "djäkla", "djävel", "djävla", "djävul", "dobbel", "docent", "dockar", "doftar", "doktor", "doldis", "dollar", "domare", "domino", "domnar", "doppar", "dotter", "dragen", "drager", "dragig", "dragit", "dragon", "drejar", "dricka", "dricks", "driven", "driver", "drivit", "droppe", "droska", "drulle", "drupit", "dryper", "dråsar", "dräper", "dröjer", "dubbar", "dubbel", "duckar", "duffel", "duggar", "duglig", "duktig", "dumbom", "dumhet", "dumpar", "dunder", "dunkar", "dunkel", "dunsar", "dussin", "dyblöt", "dykare", "dynamo", "dyning", "dyrbar", "dyrkar", "dyrort", "dyster", "dåligt", "dämmer", "dämpar", "därför", "därhän", "därmed", "dödlig", "dödsbo", "döljer", "effekt", "egoism", "egoist", "ekonom", "ekorre", "elddop", "eldhav", "eljest", "ellips", "elljus", "elsits", "elverk", "elände", "embryo", "emedan", "enbart", "enbent", "endast", "endera", "energi", "enklav", "enligt", "enslig", "episod", "erotik", "eskimå", "eskort", "essens", "estrad", "etnisk", "ettrig", "europé", "examen", "expert", "export", "extern", "extrem", "fabrik", "fackla", "fadder", "fajtas", "faktor", "faktum", "falang", "fallen", "faller", "fallit", "falnar", "familj", "famlar", "fanfar", "fantom", "farfar", "farled", "farlig", "farmor", "farsot", "farstu", "fartyg", "farväl", "fasett", "faslig", "fastar", "faster", "fastän", "fattar", "fattas", "fattig", "febrig", "febril", "feghet", "fejkar", "femtio", "femton", "feodal", "fertil", "festar", "fiasko", "fiende", "fiffel", "fiffig", "fiktiv", "filial", "filmar", "filter", "fimpar", "finans", "finess", "finger", "finish", "finito", "finner", "finska", "fintar", "fiskar", "fixare", "fjolla", "fjäder", "fjärde", "fjäril", "flagar", "flagga", "flamma", "flaska", "flaxar", "flexar", "flicka", "flinar", "flinga", "flinta", "flitig", "flotta", "flotte", "flugit", "flutit", "flygel", "flyger", "flyter", "flåsar", "flätar", "flödar", "fnurra", "fnyser", "fnöske", "fodral", "folder", "folköl", "fontän", "fordon", "forell", "formar", "format", "formel", "forsar", "fosfat", "fosfor", "fossil", "foster", "fotnot", "fradga", "framme", "framåt", "fransk", "frasar", "frasig", "fredag", "friare", "fridag", "friger", "frigid", "frigör", "frihet", "frissa", "frisyr", "frisör", "fritar", "fritid", "fritis", "frodas", "frodig", "fromma", "frossa", "frotté", "frusen", "frusit", "fryser", "frågar", "främre", "främst", "fräsch", "fräser", "fräsig", "fräter", "fröken", "fuktar", "fuktig", "fuling", "fumlar", "fumlig", "funkar", "funkis", "funnit", "funtad", "furste", "fusion", "fuskar", "futtig", "fyller", "fyllig", "fyndar", "fyndig", "fyrtio", "fysisk", "fåfäng", "fållar", "fångar", "fångst", "fåtölj", "fähund", "fäktar", "fäller", "fänrik", "färdas", "färdig", "färgad", "färgar", "fäster", "fästmö", "födsel", "följer", "förakt", "förare", "förbud", "fördel", "fördom", "förfar", "förför", "förgår", "förgås", "förgör", "förhör", "förköp", "förlag", "förlåt", "förlät", "förman", "förmer", "förmån", "förmår", "förnäm", "förnär", "förord", "förort", "förråd", "förrän", "förser", "första", "försyn", "försåt", "försök" });

            mTbxSvar.Text = ordList[ordIndex.Next(0, ordList.Count - 1)];
            AktiveraSpel();
        }

        /// <summary>
        /// behandla alla gissningar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbxGissa_TextChanged(object sender, EventArgs e)
        {
            string gissning = tbxGissa.Text;

           if (gissning == "" ) return;

            if (mTbxSvar.Text.IndexOf(gissning) < 0) {
                BehandlaFelgissning();
            } else {
                BehandlaRättgissning(gissning);
            }

           tbxGissa.Text = "";

        }

        /// <summary>
        ///  Behandla rätt gissningar, visa info om gissning och om spelare har vannat visa resultat
        /// </summary>
        /// <param name="gissning"></param>
        private void BehandlaRättgissning(string gissning) {
            if (tbxVisa.Text.Contains(gissning))
            {
                lblInfo.Text = "Du har gissat bokstaven '" + gissning + "' innan";

            } else
            {
                for (int i = 0; i < mTbxSvar.Text.Length; i++)
                {
                    if ((mTbxSvar.Text[i]).ToString() == gissning)
                    {
                        lblInfo.Text ="Bra gissning";
                        string temp = tbxVisa.Text.Remove(i, 1);
                        tbxVisa.Text = temp.Insert(i, gissning);
                    }
                }
            }
            
            lblInfo.ForeColor = Color.DarkGreen;

            if (!tbxVisa.Text.Contains('?'))
            {
                VisaResultat("Grattis!!!", "🏆 Du vann!!! \n Vill du spela igen?", true);
            }
        }

        /// <summary>
        /// Behandla rätt gissningar, visa info om gissning och om spelare har förlorat visa resultat
        /// </summary>
        private void BehandlaFelgissning()
        {

            FlyttaGubbe();
            switch (fel)
            {
                case 0:
                    lblInfo.Text = "Det finns ingen chans";
                    VisaResultat("Tyvärr", "😵 Du förlorade... \n Vill du spela igen?", false);
                    break;
                case 1:
                    lblInfo.Text = "Det finns en chans";
                    break;
                default:
                    lblInfo.Text = "Det finns "+ fel + " chanser";
                    break;
            }
            lblInfo.ForeColor = Color.DarkRed;
        }

        /// <summary>
        /// Flytta gubbes nere position om 40 och byta gubbes bild
        /// </summary>
        private void FlyttaGubbe()
        {
            int offset = 40;
            pbxGubbe.Top += offset;
            pbxGubbe.Image = Image.FromFile(bildMapp + --fel + ".ico");
        }

        /// <summary>
        /// Visa dialogrutan om man har vinnat eller förlorat
        /// </summary>
        /// <param name="titel">titel visa som dialogrutan namn</param>
        /// <param name="meddelande">meddelande visa som dialogrutans innehåll</param>
        /// <param name="ärVinner">byta dialogsrutans ikonen, när det är sanna visa info ikonen annars visa fel ikonen </param>
        public void VisaResultat(string titel, string meddelande, bool ärVinner) {
            MessageBoxIcon beläte = ärVinner ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            DialogResult beslut = MessageBox.Show(meddelande, titel, MessageBoxButtons.RetryCancel, beläte);

            if (beslut == DialogResult.Retry)
            {
                ÅterställaSpel();
            }
            else
            {
                this.Close();
            }
            
        }

    }
}
