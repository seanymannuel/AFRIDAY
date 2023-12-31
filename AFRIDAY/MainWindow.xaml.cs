﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AFRIDAY
{
    public partial class MainWindow : Window
    {
        bool btnSetIsClicked = false;
        bool shiftKeyPressed = false;
        bool capsLockEnabled = false;
        bool isEventHandlersEnabled = false;
        Label[] keyLabels = new Label[93];
        Ellipse[] key = new Ellipse[93];
        readonly Dictionary<Key, Label> labelMappings;
        SolidColorBrush outColor = new SolidColorBrush(); //Color when clicked
        SolidColorBrush origColor = new SolidColorBrush(); //BGcolor of the eclipse
        SolidColorBrush lblOutColor = new SolidColorBrush(); //Color of the label
        SolidColorBrush lblOrigColor = new SolidColorBrush(); //OriginalColor

        public MainWindow()
        {
            InitializeComponent();
            isEventHandlersEnabled = false; // Initially disable event handlers

            key[0] = eclipse1;
            key[1] = eclipse2;
            key[2] = eclipse3;
            key[3] = eclipse4;
            key[4] = eclipse5;
            key[5] = eclipse6;
            key[6] = eclipse7;
            key[7] = eclipse8;
            key[8] = eclipse9;
            key[9] = eclipse10;
            key[10] = eclipse11;
            key[11] = eclipse12;
            key[12] = eclipse13;
            key[13] = eclipse14;
            key[14] = eclipse15;
            key[15] = eclipse16;
            key[16] = eclipse17;
            key[17] = eclipse18;
            key[18] = eclipse19;
            key[19] = eclipse20;
            key[20] = eclipse21;
            key[21] = eclipse22;
            key[22] = eclipse23;
            key[23] = eclipse24;
            key[24] = eclipse25;
            key[25] = eclipse26;
            key[26] = eclipse27;
            key[27] = eclipse28;
            key[28] = eclipse29;
            key[29] = eclipse30;
            key[30] = eclipse31;
            key[31] = eclipse32;
            key[32] = eclipse33;
            key[33] = eclipse34;
            key[34] = eclipse35;
            key[35] = eclipse36;
            key[36] = eclipse37;
            key[37] = eclipse38;
            key[38] = eclipse39;
            key[39] = eclipse40;
            key[40] = eclipse41;
            key[41] = eclipse42;
            key[42] = eclipse43;
            key[43] = eclipse44;
            key[44] = eclipse45;
            key[45] = eclipse46;
            key[46] = eclipse47;
            key[47] = eclipse48;
            key[48] = eclipse49;
            key[49] = eclipse50;
            key[50] = eclipse51;
            key[51] = eclipse52;
            key[52] = eclipse53;
            key[53] = eclipse54;
            key[54] = eclipse55;
            key[55] = eclipse56;
            key[56] = eclipse57;
            key[57] = eclipse58;
            key[58] = eclipse59;
            key[59] = eclipse60;
            key[60] = eclipse61;
            key[61] = eclipse62;
            key[62] = eclipse63;
            key[63] = eclipse64;
            key[64] = eclipse65;
            key[65] = eclipse66;
            key[66] = eclipse67;
            key[67] = eclipse68;
            key[68] = eclipse69;
            key[69] = eclipse70;
            key[70] = eclipse71;
            key[71] = eclipse72;
            key[72] = eclipse73;
            key[73] = eclipse74;
            key[74] = eclipse75;
            key[75] = eclipse76;
            key[76] = eclipse77;
            key[77] = eclipse78;
            key[78] = eclipse79;
            key[79] = eclipse80;
            key[80] = eclipse81;
            key[81] = eclipse82;
            key[82] = eclipse83;
            key[83] = eclipse84;
            key[84] = eclipse85;
            key[85] = eclipse86;
            key[86] = eclipse87;
            key[87] = eclipse88;
            key[88] = eclipse89;
            key[89] = eclipse90;
            key[90] = eclipse91;
            key[91] = eclipse92;
            key[92] = eclipse93;


            keyLabels[0] = lbl1;
            keyLabels[1] = lbl2;
            keyLabels[2] = lbl3;
            keyLabels[3] = lbl4;
            keyLabels[4] = lbl5;
            keyLabels[5] = lbl6;
            keyLabels[6] = lbl7;
            keyLabels[7] = lbl8;
            keyLabels[8] = lbl9;
            keyLabels[9] = lbl10;
            keyLabels[10] = lbl11;
            keyLabels[11] = lbl12;
            keyLabels[12] = lbl13;
            keyLabels[13] = lbl14;
            keyLabels[14] = lbl15;
            keyLabels[15] = lbl16;
            keyLabels[16] = lbl17;
            keyLabels[17] = lbl18;
            keyLabels[18] = lbl19;
            keyLabels[19] = lbl20;
            keyLabels[20] = lbl21;
            keyLabels[21] = lbl22;
            keyLabels[22] = lbl23;
            keyLabels[23] = lbl24;
            keyLabels[24] = lbl25;
            keyLabels[25] = lbl26;
            keyLabels[26] = lbl27;
            keyLabels[27] = lbl28;
            keyLabels[28] = lbl29;
            keyLabels[29] = lbl30;
            keyLabels[30] = lbl31;
            keyLabels[31] = lbl32;
            keyLabels[32] = lbl33;
            keyLabels[33] = lbl34;
            keyLabels[34] = lbl35;
            keyLabels[35] = lbl36;
            keyLabels[36] = lbl37;
            keyLabels[37] = lbl38;
            keyLabels[38] = lbl39;
            keyLabels[39] = lbl40;
            keyLabels[40] = lbl41;
            keyLabels[41] = lbl42;
            keyLabels[42] = lbl43;
            keyLabels[43] = lbl44;
            keyLabels[44] = lbl45;
            keyLabels[45] = lbl46;
            keyLabels[46] = lbl47;
            keyLabels[47] = lbl48;
            keyLabels[48] = lbl49;
            keyLabels[49] = lbl50;
            keyLabels[50] = lbl51;
            keyLabels[51] = lbl52;
            keyLabels[52] = lbl53;
            keyLabels[53] = lbl54;
            keyLabels[54] = lbl55;
            keyLabels[55] = lbl56;
            keyLabels[56] = lbl57;
            keyLabels[57] = lbl58;
            keyLabels[58] = lbl59;
            keyLabels[59] = lbl60;
            keyLabels[60] = lbl61;
            keyLabels[61] = lbl62;
            keyLabels[62] = lbl63;
            keyLabels[63] = lbl64;
            keyLabels[64] = lbl65;
            keyLabels[65] = lbl66;
            keyLabels[66] = lbl67;
            keyLabels[67] = lbl68;
            keyLabels[68] = lbl69;
            keyLabels[69] = lbl70;
            keyLabels[70] = lbl71;
            keyLabels[71] = lbl72;
            keyLabels[72] = lbl73;
            keyLabels[73] = lbl74;
            keyLabels[74] = lbl75;
            keyLabels[75] = lbl76;
            keyLabels[76] = lbl77;
            keyLabels[77] = lbl78;
            keyLabels[78] = lbl79;
            keyLabels[79] = lbl80;
            keyLabels[80] = lbl81;
            keyLabels[81] = lbl82;
            keyLabels[82] = lbl83;
            keyLabels[83] = lbl84;
            keyLabels[84] = lbl85;
            keyLabels[85] = lbl86;
            keyLabels[86] = lbl87;
            keyLabels[87] = lbl88;
            keyLabels[88] = lbl89;
            keyLabels[89] = lbl90;
            keyLabels[90] = lbl91;
            keyLabels[91] = lbl92;
            keyLabels[92] = lbl93;
            

            outColor.Color = Color.FromRgb(204, 200, 170); //Color when clicked
            origColor.Color = Color.FromRgb(125, 124, 124); //BGcolor of the eclipse
            lblOutColor.Color = Color.FromRgb(0, 0, 0); //Color of the label
            lblOrigColor.Color = Color.FromRgb(255, 255, 255); //ewan ko
   
            labelMappings = new Dictionary<Key, Label>
            {
                //`12345
                { Key.D1, one },
                { Key.D2, two },
                { Key.D3, three },
                { Key.D4, four },
                { Key.D5, five },
                { Key.D6, six },
                { Key.D7, seven },
                { Key.D8, eight },
                { Key.D9, nine },
                { Key.D0, zero },
                { Key.OemMinus, minus },
                { Key.OemPlus, equal },

                //qwerty
                { Key.Q, q },
                { Key.W, w },
                { Key.R, ee },
                { Key.E, r },
                { Key.T, t },
                { Key.Y, y },
                { Key.U, u },
                { Key.I, i },
                { Key.O, o },
                { Key.P, p },
                { Key.OemOpenBrackets, l_bracket },
                { Key.OemCloseBrackets, r_bracket },
                { Key.OemPipe, b_slash },

                //asdfg
                { Key.A, a },
                { Key.S, s },
                { Key.D, d },
                { Key.F, f },
                { Key.G, g },
                { Key.H, h },
                { Key.J, j },
                { Key.K, k },
                { Key.L, el },
                { Key.OemSemicolon, semicolon },
                { Key.OemQuotes, quotation },

                //zxcvb
                { Key.Z, z },
                { Key.X, x },
                { Key.C, cc },
                { Key.V, v },
                { Key.B, b },
                { Key.N, n },
                { Key.M, m },
                { Key.OemComma, coma },
                { Key.OemPeriod, dot },
                { Key.OemQuestion, slash },

                //Special Char                
                { Key.LeftShift, shift },
                { Key.RightShift, shift },
                { Key.CapsLock, shiftlock },
                { Key.Enter, _return },               
                { Key.Tab, tab },
            };


        }

        void keyLightUp()
        {
            for (int x = 0; x < keyLabels.Length; x++)
            {
                string label = (string)keyLabels[x].Content;
                string outputLastElement = tbxOutput.Text.Last().ToString();
                if (outputLastElement == label)
                {
                    key[x].Fill = outColor;
                    keyLabels[x].Foreground = lblOutColor;
                }
                else if (outputLastElement == " ")
                {
                    for (int y = 0; y < keyLabels.Length; y++)
                    {
                        if (y == 93)
                        {
                            key[93].Fill = outColor;
                            keyLabels[93].Foreground = lblOutColor;
                        }
                        else
                        {
                            key[x].Fill = origColor;
                            keyLabels[x].Foreground = lblOrigColor;
                        }
                    }
                }
                else if (outputLastElement != label)
                {
                    key[x].Fill = origColor;
                    keyLabels[x].Foreground = lblOrigColor;
                }
            }
        }


        //private void rSettings_Click(object sender, RoutedEventArgs e)
        //{
        //    Settings newWindow = new Settings();
        //    newWindow.Show();
        //}

        //private void MenuOpen_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    ofd.Filter = "Comma Separated Values (*.csv;)|*.csv;";

        //    if (ofd.ShowDialog() == true)
        //    {
        //        FilePathTextBlock.Text = ofd.FileName;

        //        if (FilePathTextBlock.Text.Length > 0)
        //        {
        //            Rotor.LinesInRing.Clear();
        //            Array.Clear(Rotor.groupedRings, 0, Rotor.groupedRings.Length);
        //            Rotor.ringSelection = new int[3] { 0, 0, 0 };
        //            Rotor.ringSettings = new int[3] { 0, 0, 0 };
        //            updateDisplayCount();

        //            string selectedFilePath = FilePathTextBlock.Text;
        //            List<string> csvLines = Rotor.ReadFiles(selectedFilePath);

        //            if (csvLines.Count > 0)
        //            {
        //                Rotor.ringContentSeparator();
        //                ringC.Text = "Ring Count: " + Rotor.ringCount();
        //                rCount.Text = "Character Count per Ring: " + Rotor.ringContentCount();
        //                MessageBox.Show("Rings File has been Read and Formatted successfully! Please Proceed with the setup.\nFeel free to select another csv file that contains rings if you want.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);
        //                btnPlusSeconds1.IsEnabled = true;
        //                btnPlusMinutes1.IsEnabled = true;
        //                btnPlusHours1.IsEnabled = true;
        //                btnMinusSeconds1.IsEnabled = true;
        //                btnMinusMinutes1.IsEnabled = true;
        //                btnMinusHours1.IsEnabled = true;
        //                MenuOpen.IsEnabled = true;
        //                cbxReflector.IsEnabled = true;
        //                btnReset.IsEnabled = true;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Failed to read the CSV file.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //            }
        //        }
        //    }
        //}


        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            bool fileReadSuccessfully = false;

            do
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Comma Separated Values (*.csv;)|*.csv;";
                if (ofd.ShowDialog() == true)
                {
                    FilePathTextBlock.Text = ofd.FileName;

                    if (FilePathTextBlock.Text.Length > 0)
                    {
                        Rotor.LinesInRing.Clear();
                        Array.Clear(Rotor.groupedRings, 0, Rotor.groupedRings.Length);
                        Rotor.ringSelection = new int[3] { 0, 0, 0 };
                        Rotor.ringSettings = new int[3] { 0, 0, 0 };

                        fileReadSuccessfully = Rotor.ReadFiles(FilePathTextBlock.Text);

                        if (fileReadSuccessfully)
                        {
                            updateDisplayCount();
                            Rotor.ringContentSeparator();
                            ringC.Text = "Ring Count : " + Rotor.ringCount();
                            rCount.Text = "Character Count per Ring : " + Rotor.ringContentCount();
                            MessageBox.Show("Rings File has been Read and Formatted successfully! Please Proceed with the setup.\nFeel free to select another csv file that contains rings if you want.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);

                            ToggleControls(true);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid CSV file.", "Invalid File", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                }
                else
                {
                    // User cancelled the file dialog
                    return;
                }
            }
            while (!fileReadSuccessfully);
        }


        private void ToggleControls(bool isEnabled)
        {
            btnPlusSeconds1.IsEnabled = isEnabled;
            btnPlusMinutes1.IsEnabled = isEnabled;
            btnPlusHours1.IsEnabled = isEnabled;
            btnMinusSeconds1.IsEnabled = isEnabled;
            btnMinusMinutes1.IsEnabled = isEnabled;
            btnMinusHours1.IsEnabled = isEnabled;
            MenuOpen.IsEnabled = isEnabled;
            cbxReflector.IsEnabled = isEnabled;
            btnReset.IsEnabled = isEnabled;
        }


        private void EnableEventHandlers()
        {
            isEventHandlersEnabled = true;
        }

        private void DisableEventHandlers()
        {
            isEventHandlersEnabled = false;
        }

        void updateDisplayCount()
        {
            lblSelectionSecondsCounter1.Content = Rotor.countDisplayFormatter(Rotor.ringSelection[0]);
            lblSelectionMinutesCounter1.Content = Rotor.countDisplayFormatter(Rotor.ringSelection[1]);
            lblSelectionHoursCounter1.Content = Rotor.countDisplayFormatter(Rotor.ringSelection[2]);

            lblSelectionSecondsCounter2.Content = Rotor.countDisplayFormatter(Rotor.ringSettings[0]);
            lblSelectionMinutesCounter2.Content = Rotor.countDisplayFormatter(Rotor.ringSettings[1]);
            lblSelectionHoursCounter2.Content = Rotor.countDisplayFormatter(Rotor.ringSettings[2]);
        }

        void ringSelectorChecker()
        {
            if (Rotor.ringSelection[0] == Rotor.ringSelection[1] || Rotor.ringSelection[1] == Rotor.ringSelection[2] || Rotor.ringSelection[0] == Rotor.ringSelection[2])
            {
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
            }
            else
            {
                btnPlusSeconds2.IsEnabled = true;
                btnPlusMinutes2.IsEnabled = true;
                btnPlusHours2.IsEnabled = true;
                btnMinusSeconds2.IsEnabled = true;
                btnMinusMinutes2.IsEnabled = true;
                btnMinusHours2.IsEnabled = true;
                btnSet.IsEnabled = true;
            }
        }




        private void btnPlusSeconds1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(0, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusMinutes1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(1, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusHours1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(2, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusSeconds1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(0, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusMinutes1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(1, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusHours1_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSelectionCounter(2, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusSeconds2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(0, '+');
            updateDisplayCount();
        }

        private void btnPlusMinutes2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(1, '+');
            updateDisplayCount();
        }

        private void btnPlusHours2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(2, '+');
            updateDisplayCount();
        }

        private void btnMinusSeconds2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(0, '-');
            updateDisplayCount();
        }

        private void btnMinusMinutes2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(1, '-');
            updateDisplayCount();
        }

        private void btnMinusHours2_Click(object sender, RoutedEventArgs e)
        {
            Rotor.ringSettingsCounter(2, '-');
            updateDisplayCount();
        }

        private void cbxReflector_Checked(object sender, RoutedEventArgs e)
        {
            Rotor.checkboxIsChecked = true;
        }

        private void cbxReflector_Unchecked(object sender, RoutedEventArgs e)
        {
            Rotor.checkboxIsChecked = false;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            btnSetIsClicked = true;
            if (MessageBox.Show("Are you sure you want to LOCK the Settings?", "Enigma", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Settings and selecting CSV File will be unavailable.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Warning);
                Rotor.offsetRotors();
                MessageBox.Show("Enigma is now activated!", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);

                btnPlusSeconds1.IsEnabled = false;
                btnPlusMinutes1.IsEnabled = false;
                btnPlusHours1.IsEnabled = false;
                btnMinusSeconds1.IsEnabled = false;
                btnMinusMinutes1.IsEnabled = false;
                btnMinusHours1.IsEnabled = false;
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
                MenuOpen.IsEnabled = false;
                cbxReflector.IsEnabled = false;
                tbxInput.Focus();
                EnableEventHandlers();
            }
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {

          
            if (btnSetIsClicked)
            {
                //bool isCapsLockOn = Console.CapsLock;
                if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift || capsLockEnabled)
                {
                    switch (e.Key)
                    {
                        case Key.A:
                            tbxInput.Text += 'A';
                            tbxOutput.Text += Rotor.encrypted('A');
                            keyLightUp();
                            break;
                        case Key.B:
                            tbxInput.Text += 'B';
                            tbxOutput.Text += Rotor.encrypted('B');
                            keyLightUp();
                            break;
                        case Key.C:
                            tbxInput.Text += 'C';
                            tbxOutput.Text += Rotor.encrypted('C');
                            keyLightUp();
                            break;
                        case Key.D:
                            tbxInput.Text += 'D';
                            tbxOutput.Text += Rotor.encrypted('D');
                            keyLightUp();
                            break;
                        case Key.E:
                            tbxInput.Text += 'E';
                            tbxOutput.Text += Rotor.encrypted('E');
                            keyLightUp();
                            break;
                        case Key.F:
                            tbxInput.Text += 'F';
                            tbxOutput.Text += Rotor.encrypted('F');
                            keyLightUp();
                            break;
                        case Key.G:
                            tbxInput.Text += 'G';
                            tbxOutput.Text += Rotor.encrypted('G');
                            keyLightUp();
                            break;
                        case Key.H:
                            tbxInput.Text += 'H';
                            tbxOutput.Text += Rotor.encrypted('H');
                            keyLightUp();
                            break;
                        case Key.I:
                            tbxInput.Text += 'I';
                            tbxOutput.Text += Rotor.encrypted('I');
                            keyLightUp();
                            break;
                        case Key.J:
                            tbxInput.Text += 'J';
                            tbxOutput.Text += Rotor.encrypted('J');
                            keyLightUp();
                            break;
                        case Key.K:
                            tbxInput.Text += 'K';
                            tbxOutput.Text += Rotor.encrypted('K');
                            keyLightUp();
                            break;
                        case Key.L:
                            tbxInput.Text += 'L';
                            tbxOutput.Text += Rotor.encrypted('L');
                            keyLightUp();
                            break;
                        case Key.M:
                            tbxInput.Text += 'M';
                            tbxOutput.Text += Rotor.encrypted('M');
                            keyLightUp();
                            break;
                        case Key.N:
                            tbxInput.Text += 'N';
                            tbxOutput.Text += Rotor.encrypted('N');
                            keyLightUp();
                            break;
                        case Key.O:
                            tbxInput.Text += 'O';
                            tbxOutput.Text += Rotor.encrypted('O');
                            keyLightUp();
                            break;
                        case Key.P:
                            tbxInput.Text += 'P';
                            tbxOutput.Text += Rotor.encrypted('P');
                            keyLightUp();
                            break;
                        case Key.Q:
                            tbxInput.Text += 'Q';
                            tbxOutput.Text += Rotor.encrypted('Q');
                            keyLightUp();
                            break;
                        case Key.R:
                            tbxInput.Text += 'R';
                            tbxOutput.Text += Rotor.encrypted('R');
                            keyLightUp();
                            break;
                        case Key.S:
                            tbxInput.Text += 'S';
                            tbxOutput.Text += Rotor.encrypted('S');
                            keyLightUp();
                            break;
                        case Key.T:
                            tbxInput.Text += 'T';
                            tbxOutput.Text += Rotor.encrypted('T');
                            keyLightUp();
                            break;
                        case Key.U:
                            tbxInput.Text += 'U';
                            tbxOutput.Text += Rotor.encrypted('U');
                            keyLightUp();
                            break;
                        case Key.V:
                            tbxInput.Text += 'V';
                            tbxOutput.Text += Rotor.encrypted('V');
                            keyLightUp();
                            break;
                        case Key.W:
                            tbxInput.Text += 'W';
                            tbxOutput.Text += Rotor.encrypted('W');
                            keyLightUp();
                            break;
                        case Key.X:
                            tbxInput.Text += 'X';
                            tbxOutput.Text += Rotor.encrypted('X');
                            keyLightUp();
                            break;
                        case Key.Y:
                            tbxInput.Text += 'Y';
                            tbxOutput.Text += Rotor.encrypted('Y');
                            keyLightUp();
                            break;
                        case Key.Z:
                            tbxInput.Text += 'Z';
                            tbxOutput.Text += Rotor.encrypted('Z');
                            keyLightUp();
                            break;
                        case Key.D0:
                            tbxInput.Text += ')';
                            tbxOutput.Text += Rotor.encrypted(')');
                            keyLightUp();
                            break;
                        case Key.D1:
                            tbxInput.Text += '!';
                            tbxOutput.Text += Rotor.encrypted('!');
                            keyLightUp();
                            break;
                        case Key.D2:
                            tbxInput.Text += '@';
                            tbxOutput.Text += Rotor.encrypted('@');
                            keyLightUp();
                            break;
                        case Key.D3:
                            tbxInput.Text += '#';
                            tbxOutput.Text += Rotor.encrypted('#');
                            keyLightUp();
                            break;
                        case Key.D4:
                            tbxInput.Text += '$';
                            tbxOutput.Text += Rotor.encrypted('$');
                            keyLightUp();
                            break;
                        case Key.D5:
                            tbxInput.Text += '%';
                            tbxOutput.Text += Rotor.encrypted('%');
                            keyLightUp();
                            break;
                        case Key.D6:
                            tbxInput.Text += '^';
                            tbxOutput.Text += Rotor.encrypted('^');
                            keyLightUp();
                            break;
                        case Key.D7:
                            tbxInput.Text += '&';
                            tbxOutput.Text += Rotor.encrypted('&');
                            keyLightUp();
                            break;
                        case Key.D8:
                            tbxInput.Text += '*';
                            tbxOutput.Text += Rotor.encrypted('*');
                            keyLightUp();
                            break;
                        case Key.D9:
                            tbxInput.Text += '(';
                            tbxOutput.Text += Rotor.encrypted('(');
                            keyLightUp();
                            break;
                        case Key.Oem1:
                            tbxInput.Text += ':';
                            tbxOutput.Text += Rotor.encrypted(':');
                            keyLightUp();
                            break;
                        case Key.Oem2:
                            tbxInput.Text += '?';
                            tbxOutput.Text += Rotor.encrypted('?');
                            keyLightUp();
                            break;
                        case Key.Oem4:
                            tbxInput.Text += '{';
                            tbxOutput.Text += Rotor.encrypted('{');
                            keyLightUp();
                            break;
                        case Key.Oem5:
                            tbxInput.Text += '|';
                            tbxOutput.Text += Rotor.encrypted('|');
                            keyLightUp();
                            break;
                        case Key.Oem6:
                            tbxInput.Text += '}';
                            tbxOutput.Text += Rotor.encrypted('}');
                            keyLightUp();
                            break;
                        case Key.OemComma:
                            tbxInput.Text += '<';
                            tbxOutput.Text += Rotor.encrypted('<');
                            keyLightUp();
                            break;
                        case Key.OemPeriod:
                            tbxInput.Text += '>';
                            tbxOutput.Text += Rotor.encrypted('>');
                            keyLightUp();
                            break;
                        case Key.OemMinus:
                            tbxInput.Text += '_';
                            tbxOutput.Text += Rotor.encrypted('_');
                            keyLightUp();
                            break;
                        case Key.OemPlus:
                            tbxInput.Text += '+';
                            tbxOutput.Text += Rotor.encrypted('+');
                            keyLightUp();
                            break;
                        case Key.OemQuotes:
                            tbxInput.Text += '"';
                            tbxOutput.Text += Rotor.encrypted('"');
                            keyLightUp();
                            break;
                        case Key.Space:
                            tbxInput.Text += ' ';
                            tbxOutput.Text += Rotor.encrypted(' ');
                            keyLightUp();
                            break;
                    }
                    //updateDisplayCount();
                }
                else
                {
                    switch (e.Key)
                    {
                        case Key.A:
                            tbxInput.Text += 'a';
                            tbxOutput.Text += Rotor.encrypted('a');
                            keyLightUp();
                            break;
                        case Key.B:
                            tbxInput.Text += 'b';
                            tbxOutput.Text += Rotor.encrypted('b');
                            keyLightUp();
                            break;
                        case Key.C:
                            tbxInput.Text += 'c';
                            tbxOutput.Text += Rotor.encrypted('c');
                            keyLightUp();
                            break;
                        case Key.D:
                            tbxInput.Text += 'd';
                            tbxOutput.Text += Rotor.encrypted('d');
                            keyLightUp();
                            break;
                        case Key.E:
                            tbxInput.Text += 'e';
                            tbxOutput.Text += Rotor.encrypted('e');
                            keyLightUp();
                            break;
                        case Key.F:
                            tbxInput.Text += 'f';
                            tbxOutput.Text += Rotor.encrypted('f');
                            keyLightUp();
                            break;
                        case Key.G:
                            tbxInput.Text += 'g';
                            tbxOutput.Text += Rotor.encrypted('g');
                            keyLightUp();
                            break;
                        case Key.H:
                            tbxInput.Text += 'h';
                            tbxOutput.Text += Rotor.encrypted('h');
                            keyLightUp();
                            break;
                        case Key.I:
                            tbxInput.Text += 'i';
                            tbxOutput.Text += Rotor.encrypted('i');
                            keyLightUp();
                            break;
                        case Key.J:
                            tbxInput.Text += 'j';
                            tbxOutput.Text += Rotor.encrypted('j');
                            keyLightUp();
                            break;
                        case Key.K:
                            tbxInput.Text += 'k';
                            tbxOutput.Text += Rotor.encrypted('k');
                            keyLightUp();
                            break;
                        case Key.L:
                            tbxInput.Text += 'l';
                            tbxOutput.Text += Rotor.encrypted('l');
                            keyLightUp();
                            break;
                        case Key.M:
                            tbxInput.Text += 'm';
                            tbxOutput.Text += Rotor.encrypted('m');
                            keyLightUp();
                            break;
                        case Key.N:
                            tbxInput.Text += 'n';
                            tbxOutput.Text += Rotor.encrypted('n');
                            keyLightUp();
                            break;
                        case Key.O:
                            tbxInput.Text += 'o';
                            tbxOutput.Text += Rotor.encrypted('o');
                            keyLightUp();
                            break;
                        case Key.P:
                            tbxInput.Text += 'p';
                            tbxOutput.Text += Rotor.encrypted('p');
                            keyLightUp();
                            break;
                        case Key.Q:
                            tbxInput.Text += 'q';
                            tbxOutput.Text += Rotor.encrypted('q');
                            keyLightUp();
                            break;
                        case Key.R:
                            tbxInput.Text += 'r';
                            tbxOutput.Text += Rotor.encrypted('r');
                            keyLightUp();
                            break;
                        case Key.S:
                            tbxInput.Text += 's';
                            tbxOutput.Text += Rotor.encrypted('s');
                            keyLightUp();
                            break;
                        case Key.T:
                            tbxInput.Text += 't';
                            tbxOutput.Text += Rotor.encrypted('t');
                            keyLightUp();
                            break;
                        case Key.U:
                            tbxInput.Text += 'u';
                            tbxOutput.Text += Rotor.encrypted('u');
                            keyLightUp();
                            break;
                        case Key.V:
                            tbxInput.Text += 'v';
                            tbxOutput.Text += Rotor.encrypted('v');
                            keyLightUp();
                            break;
                        case Key.W:
                            tbxInput.Text += 'w';
                            tbxOutput.Text += Rotor.encrypted('w');
                            keyLightUp();
                            break;
                        case Key.X:
                            tbxInput.Text += 'x';
                            tbxOutput.Text += Rotor.encrypted('x');
                            keyLightUp();
                            break;
                        case Key.Y:
                            tbxInput.Text += 'y';
                            tbxOutput.Text += Rotor.encrypted('y');
                            keyLightUp();
                            break;
                        case Key.Z:
                            tbxInput.Text += 'z';
                            tbxOutput.Text += Rotor.encrypted('z');
                            keyLightUp();
                            break;
                        case Key.NumPad0:
                        case Key.D0:
                            tbxInput.Text += '0';
                            tbxOutput.Text += Rotor.encrypted('0');
                            keyLightUp();
                            break;
                        case Key.NumPad1:
                        case Key.D1:
                            tbxInput.Text += '1';
                            tbxOutput.Text += Rotor.encrypted('1');
                            keyLightUp();
                            break;
                        case Key.NumPad2:
                        case Key.D2:
                            tbxInput.Text += '2';
                            tbxOutput.Text += Rotor.encrypted('2');
                            keyLightUp();
                            break;
                        case Key.NumPad3:
                        case Key.D3:
                            tbxInput.Text += '3';
                            tbxOutput.Text += Rotor.encrypted('3');
                            keyLightUp();
                            break;
                        case Key.NumPad4:
                        case Key.D4:
                            tbxInput.Text += '4';
                            tbxOutput.Text += Rotor.encrypted('4');
                            keyLightUp();
                            break;
                        case Key.NumPad5:
                        case Key.D5:
                            tbxInput.Text += '5';
                            tbxOutput.Text += Rotor.encrypted('5');
                            keyLightUp();
                            break;
                        case Key.NumPad6:
                        case Key.D6:
                            tbxInput.Text += '6';
                            tbxOutput.Text += Rotor.encrypted('6');
                            keyLightUp();
                            break;
                        case Key.NumPad7:
                        case Key.D7:
                            tbxInput.Text += '7';
                            tbxOutput.Text += Rotor.encrypted('7');
                            keyLightUp();
                            break;
                        case Key.NumPad8:
                        case Key.D8:
                            tbxInput.Text += '8';
                            tbxOutput.Text += Rotor.encrypted('8');
                            keyLightUp();
                            break;
                        case Key.NumPad9:
                        case Key.D9:
                            tbxInput.Text += '9';
                            tbxOutput.Text += Rotor.encrypted('9');
                            keyLightUp();
                            break;
                        case Key.Oem1:
                            tbxInput.Text += ';';
                            tbxOutput.Text += Rotor.encrypted(';');
                            keyLightUp();
                            break;
                        case Key.Divide:
                        case Key.Oem2:
                            tbxInput.Text += '/';
                            tbxOutput.Text += Rotor.encrypted('/');
                            keyLightUp();
                            break;
                        case Key.Oem4:
                            tbxInput.Text += '[';
                            tbxOutput.Text += Rotor.encrypted('[');
                            keyLightUp();
                            break;
                        case Key.Oem5:
                            tbxInput.Text += '\\';
                            tbxOutput.Text += Rotor.encrypted('\\');
                            keyLightUp();
                            break;
                        case Key.Oem6:
                            tbxInput.Text += ']';
                            tbxOutput.Text += Rotor.encrypted(']');
                            keyLightUp();
                            break;
                        case Key.OemComma:
                            tbxInput.Text += ',';
                            tbxOutput.Text += Rotor.encrypted(',');
                            keyLightUp();
                            break;
                        case Key.OemPeriod:
                        case Key.Decimal:
                            tbxInput.Text += '.';
                            tbxOutput.Text += Rotor.encrypted('.');
                            keyLightUp();
                            break;
                        case Key.Subtract:
                        case Key.OemMinus:
                            tbxInput.Text += '-';
                            tbxOutput.Text += Rotor.encrypted('-');
                            keyLightUp();
                            break;
                        case Key.OemPlus:
                            tbxInput.Text += '=';
                            tbxOutput.Text += Rotor.encrypted('=');
                            keyLightUp();
                            break;
                        case Key.Add:
                            tbxInput.Text += '+';
                            tbxOutput.Text += Rotor.encrypted('+');
                            keyLightUp();
                            break;
                        case Key.Multiply:
                            tbxInput.Text += '*';
                            tbxOutput.Text += Rotor.encrypted('*');
                            keyLightUp();
                            break;
                        case Key.OemQuotes:
                            tbxInput.Text += '\'';
                            tbxOutput.Text += Rotor.encrypted('\'');
                            keyLightUp();
                            break;
                        case Key.Space:
                            tbxInput.Text += ' ';
                            tbxOutput.Text += Rotor.encrypted(' ');
                            keyLightUp();
                            break;

                    }
                    updateDisplayCount();
                }
            }
        }

        private void tbxInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (btnSetIsClicked)
            {
                switch (e.Key)
                {
                    case Key.Enter:
                        Rotor.inputTextbox('\n');
                        Rotor.txtbOutput.Add('\n');
                        tbxInput.Text += '\n';
                        tbxOutput.Text += '\n';
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = origColor;
                            keyLabels[x].Foreground = lblOrigColor;
                        }
                        break;
                    case Key.Space:
                        tbxInput.Text += ' ';
                        tbxOutput.Text += Rotor.encrypted(' ');
                        keyLightUp();
                        break;

                    case Key.Tab:
                        tbxInput.Text += "\t";                       
                        break;
                        

                    case Key.Back:
                        if (tbxInput.Text.Length > 0 && tbxOutput.Text.Length > 0)
                        {
                            for (int x = Rotor.txtbInput.Count - 1; x >= 0; x--)
                            {
                                if (Rotor.txtbInput[x] == '\n')
                                {
                                    tbxInput.Text = Rotor.backspaceInput();
                                    tbxOutput.Text = Rotor.backspaceOutput();
                                    break;
                                }
                                else
                                {
                                    Rotor.reverseRotor();
                                    tbxInput.Text = Rotor.backspaceInput();
                                    tbxOutput.Text = Rotor.backspaceOutput();
                                    break;
                                }
                            }
                        }
                        updateDisplayCount();
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = origColor;
                            keyLabels[x].Foreground = lblOrigColor;
                        }
                        break;
                }
            }
        }


        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enigma is going to RESET", "Enigma", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (MessageBox.Show("Are you sure you want to RESET enigma setup and select another CSV File?", "Enigma", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //tbxRingFilePath.Text = "";
                //lblRingCount.Content = "Ring Count: ";
                //lblRingContentCount.Content = "Ring Count Content: ";
                DisableEventHandlers();
                //Rotor.ClearRingLines();
                tbxInput.Text = "";
                tbxOutput.Text = "";
                cbxReflector.IsChecked = false;
                Rotor.txtbInput.Clear();
                Rotor.txtbOutput.Clear();
                Rotor.ringSelection = new int[3] { 0, 0, 0 };
                Rotor.ringSettings = new int[3] { 0, 0, 0 };               
                updateDisplayCount();
                Rotor.offsetRotors();
                btnSetIsClicked = false;
                DisableEventHandlers();
                btnPlusSeconds1.IsEnabled = false;
                btnPlusMinutes1.IsEnabled = false;
                btnPlusHours1.IsEnabled = false;
                btnMinusSeconds1.IsEnabled = false;
                btnMinusMinutes1.IsEnabled = false;
                btnMinusHours1.IsEnabled = false;
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
                cbxReflector.IsEnabled = true;
                MenuOpen.IsEnabled = true;                
                Rotor.checkboxIsChecked = false;
                for (int x = 0; x < key.Length; x++)
                {
                    key[x].Fill = origColor;
                    keyLabels[x].Foreground = lblOrigColor;
                }
                MessageBox.Show("The Enigma setup is RESET.\nSelect another CSV File.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isEventHandlersEnabled)
            {
                // Event handlers are disabled, do nothing
                return;
            }
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift) // Handle the Shift key
            {
                shiftKeyPressed = true;
                shift.Background = outColor; // Change UI element appearance
                // Replace letters with symbols
                if (shiftKeyPressed)
                {
                    a.Content = "A";
                    b.Content = "B";
                    cc.Content = "C";
                    d.Content = "D";
                    ee.Content = "E";
                    f.Content = "F";
                    g.Content = "G";
                    h.Content = "H";
                    i.Content = "I";
                    j.Content = "J";
                    k.Content = "K";
                    el.Content = "L";
                    m.Content = "M";
                    n.Content = "N";
                    o.Content = "O";
                    p.Content = "P";
                    q.Content = "Q";
                    r.Content = "R";
                    s.Content = "S";
                    t.Content = "T";
                    u.Content = "U";
                    v.Content = "V";
                    w.Content = "W";
                    x.Content = "X";
                    y.Content = "Y";
                    z.Content = "Z";

                    // Change Symbols
                    equal.Content = "+";
                    minus.Content = "_";
                    coma.Content = "<";
                    dot.Content = ">";
                    semicolon.Content = ":";
                    quotation.Content = '"';
                    slash.Content = "?";
                    b_slash.Content = "|";
                    l_bracket.Content = "{";
                    r_bracket.Content = "}";

                    // Replace numbers with symbols
                    one.Content = "!";
                    two.Content = "@";
                    three.Content = "#";
                    four.Content = "$";
                    five.Content = "%";
                    six.Content = "^";
                    seven.Content = "&";
                    eight.Content = "*";
                    nine.Content = "(";
                    zero.Content = ")";
                }
                return;
            }


                if (e.Key == Key.CapsLock)
                {
                    capsLockEnabled = !capsLockEnabled; // Toggle Caps Lock state              
                    shiftlock.Content = capsLockEnabled ? "Caps Lock" : "Shift Lock";  // Update your Shift Lock label text or appearance here
                    shiftlock.Background = outColor;
                    if (capsLockEnabled)
                    {
                        // Replace letters with symbols
                        a.Content = "A";
                        b.Content = "B";
                        cc.Content = "C";
                        d.Content = "D";
                        ee.Content = "E";
                        f.Content = "F";
                        g.Content = "G";
                        h.Content = "H";
                        i.Content = "I";
                        j.Content = "J";
                        k.Content = "K";
                        el.Content = "L";
                        m.Content = "M";
                        n.Content = "N";
                        o.Content = "O";
                        p.Content = "P";
                        q.Content = "Q";
                        r.Content = "R";
                        s.Content = "S";
                        t.Content = "T";
                        u.Content = "U";
                        v.Content = "V";
                        w.Content = "W";
                        x.Content = "X";
                        y.Content = "Y";
                        z.Content = "Z";

                        // Change Symbols
                        equal.Content = "+";
                        minus.Content = "_";
                        coma.Content = "<";
                        dot.Content = ">";
                        semicolon.Content = ":";
                        quotation.Content = '"';
                        slash.Content = "?";
                        b_slash.Content = "|";
                        l_bracket.Content = "{";
                        r_bracket.Content = "}";

                        // Replace numbers with symbols
                        one.Content = "!";
                        two.Content = "@";
                        three.Content = "#";
                        four.Content = "$";
                        five.Content = "%";
                        six.Content = "^";
                        seven.Content = "&";
                        eight.Content = "*";
                        nine.Content = "(";
                        zero.Content = ")";
                    }
                    else
                    {
                        // If Caps Lock is disabled, revert back to letters and numbers
                        a.Content = "a";
                        b.Content = "b";
                        cc.Content = "c";
                        d.Content = "d";
                        ee.Content = "e";
                        f.Content = "f";
                        g.Content = "g";
                        h.Content = "h";
                        i.Content = "i";
                        j.Content = "j";
                        k.Content = "k";
                        el.Content = "l";
                        m.Content = "m";
                        n.Content = "n";
                        o.Content = "o";
                        p.Content = "p";
                        q.Content = "q";
                        r.Content = "r";
                        s.Content = "s";
                        t.Content = "t";
                        u.Content = "u";
                        v.Content = "v";
                        w.Content = "w";
                        x.Content = "x";
                        y.Content = "y";
                        z.Content = "z";
                        equal.Content = "=";
                        minus.Content = "-";
                        coma.Content = ",";
                        dot.Content = ".";
                        semicolon.Content = ";";
                        quotation.Content = "'";
                        slash.Content = "/";
                        b_slash.Content = "\\";
                        l_bracket.Content = "[";
                        r_bracket.Content = "]";

                        // Revert numbers back to their original values
                        one.Content = "1";
                        two.Content = "2";
                        three.Content = "3";
                        four.Content = "4";
                        five.Content = "5";
                        six.Content = "6";
                        seven.Content = "7";
                        eight.Content = "8";
                        nine.Content = "9";
                        zero.Content = "0";
                    }
                    return;

                }
                // Handle key press event to change the label background color.
                if (labelMappings.TryGetValue(e.Key, out var targetLabel))
                {
                    targetLabel.Background = outColor;
                }
                if(e.Key == Key.Back)
            {
                back.Background = Brushes.Gray;
            }
        }

            private void Window_KeyUp(object sender, KeyEventArgs e)
            {
            if (!isEventHandlersEnabled)
            {
                // Event handlers are disabled, do nothing
                return;
            }



            if (shiftKeyPressed)
            {
                a.Content = "a";
                b.Content = "b";
                cc.Content = "c";
                d.Content = "d";
                ee.Content = "e";
                f.Content = "f";
                g.Content = "g";
                h.Content = "h";
                i.Content = "i";
                j.Content = "j";
                k.Content = "k";
                el.Content = "l";
                m.Content = "m";
                n.Content = "n";
                o.Content = "o";
                p.Content = "p";
                q.Content = "q";
                r.Content = "r";
                s.Content = "s";
                t.Content = "t";
                u.Content = "u";
                v.Content = "v";
                w.Content = "w";
                x.Content = "x";
                y.Content = "y";
                z.Content = "z";
                equal.Content = "=";
                minus.Content = "-";
                coma.Content = ",";
                dot.Content = ".";
                semicolon.Content = ";";
                quotation.Content = "'";
                slash.Content = "/";
                b_slash.Content = "\\";
                l_bracket.Content = "[";
                r_bracket.Content = "]";

                // Revert numbers back to their original values
                one.Content = "1";
                two.Content = "2";
                three.Content = "3";
                four.Content = "4";
                five.Content = "5";
                six.Content = "6";
                seven.Content = "7";
                eight.Content = "8";
                nine.Content = "9";
                zero.Content = "0";
            }       
                if (e.Key == Key.CapsLock && Keyboard.IsKeyToggled(Key.CapsLock))
                {
                    return;
                }

                if (labelMappings.TryGetValue(e.Key, out var targetLabel))
                {
                    targetLabel.Background = Brushes.Transparent;
                }

            if (e.Key == Key.Back)
            {
                back.Background = Brushes.Transparent;
            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to CLOSE Enigma Machine?", "Enigma", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
