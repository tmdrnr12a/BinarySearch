using System;
using System.Linq;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class MainForm : Form
    {
        #region " Variables "

        #endregion " Variables End"

        #region " Create & Load & Shown "

        public MainForm()
        {
            InitializeComponent();

            this.Shown += MainForm_Shown;

            uiBtn_Search.Click += UiBtn_Search_Click;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InitForm();
        }

        #endregion " Create & Load & Shown End "

        #region " Methods "

        /// <summary>
        /// Initialize Numeric up/down value
        /// </summary>
        private void InitForm()
        {
            uiNum_MaxValue.Maximum = 100000000;     // 100,000,000
            uiNum_MaxValue.Value = uiNum_MaxValue.Maximum;
            uiNum_MaxValue.ThousandsSeparator = true;

            uiNum_ValueToFind.Maximum = 100000000;          // 100,000,000
            uiNum_ValueToFind.Value = 1;
            uiNum_ValueToFind.ThousandsSeparator = true;
        }

        /// <summary>
        /// Check max value and value to find value
        /// </summary>
        /// <returns></returns>
        private bool CheckValue()
        {
            bool result = true;

            if (uiNum_ValueToFind.Value < 1 && uiNum_ValueToFind.Value > uiNum_MaxValue.Value)
            {
                MessageBox.Show("Check search condition", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Find value in array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="targetNum"></param>
        /// <param name="startIdx"></param>
        /// <param name="endIdx"></param>
        /// <param name="seq"></param>
        private void FindValue(int[] arr, int targetNum, int startIdx, int endIdx, int seq)
        {
            if (startIdx > endIdx)
            {
                string msg = "Value to find in array does not exist.";
                MessageBox.Show(msg, "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            seq++;
            int midIdx = (startIdx + endIdx) / 2;
            uiRtb_Content.AppendText($"{seq}. Array[{midIdx}] = {arr[midIdx]}\n");

            if (arr[midIdx] == targetNum)
                uiRtb_Content.AppendText($"=> Found value {targetNum}.\n");
            
            else if (arr[midIdx] < targetNum)
                FindValue(arr, targetNum, midIdx + 1, endIdx, seq);
            
            else
                FindValue(arr, targetNum, startIdx, midIdx - 1, seq);
        }

        #endregion " Methods End "

        #region " Events "

        private void UiBtn_Search_Click(object sender, EventArgs e)
        {
            if (CheckValue() == false)
                return;

            uiRtb_Content.Clear();
            int[] arr = Enumerable.Range(1, (int)uiNum_MaxValue.Value).ToArray();

            uiRtb_Content.AppendText("--- Binary Search Start !! ---\n");
            FindValue(arr, (int)uiNum_ValueToFind.Value, 0, arr.Length - 1, 0);
            uiRtb_Content.AppendText("--- Binary Search End !! ---\n");
        }

        #endregion " Events End "
    }
}
