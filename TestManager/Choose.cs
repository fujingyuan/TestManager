using NationalInstruments.TestStand.Interop.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestManager
{
    public class Choose : IDisposable
    {
        public FormData mFormData = Singleton.Instance.Data;
        private TestForm mForm = null;
        private NationalInstruments.TestStand.Interop.API.SequenceContext mSequenceContext;

        public Choose(NationalInstruments.TestStand.Interop.API.SequenceContext sequenceContext)
        {
            mSequenceContext = sequenceContext;
            this.mForm = new TestForm(mSequenceContext);

        }

        public void SequenceInit(out bool errorOccurred, out int errorCode, out String errorMsg)
        {
            errorOccurred = false;
            errorCode = 0;
            errorMsg = String.Empty;
            this.mForm.InitializeTerminationStateChecking();
            mFormData.Loop = true;
            mFormData.Count = 0;
            mFormData.Exit = false;
        }

        public void UpdateSequecePara(out bool loop,
            out string Prescan_dir,
            out double Para_1,
            out double Para_2,
            out double Para_3,
            out double Para_4,
            out double Para_5,
            out double Para_6)

        {
            if (mFormData.Exit == true)
            {
                this.mForm.TimerStop();
                mFormData.Loop = false;
                loop = false;
                Prescan_dir = mFormData.SeqMap[mFormData.TableData.Rows[mFormData.Count][2].ToString()];
                Para_1 = getValue(mFormData.TableData.Rows[mFormData.Count][3]);
                Para_2 = getValue(mFormData.TableData.Rows[mFormData.Count][4]);
                Para_3 = getValue(mFormData.TableData.Rows[mFormData.Count][5]);
                Para_4 = getValue(mFormData.TableData.Rows[mFormData.Count][6]);
                Para_5 = getValue(mFormData.TableData.Rows[mFormData.Count][7]);
                Para_6 = getValue(mFormData.TableData.Rows[mFormData.Count][8]);
                this.mForm.Close();
                return;
            }

            if (mFormData.Count > 0 && mFormData.Count <= mFormData.TableData.Rows.Count - 1)
            {
                this.mForm.TimerStart();
            }
            else if(mFormData.Count ==0)
            {
                this.mForm.TimerStop();
            }
            else
            {

            }
            this.mForm.ShowDialog();
            if (mFormData.Exit == true)
            {
                mFormData.Loop = false;
                loop = false;
            }
            Prescan_dir = mFormData.SeqMap[mFormData.TableData.Rows[mFormData.Count][2].ToString()];
            Para_1 = getValue(mFormData.TableData.Rows[mFormData.Count][3]);
            Para_2 = getValue(mFormData.TableData.Rows[mFormData.Count][4]);
            Para_3 = getValue(mFormData.TableData.Rows[mFormData.Count][5]);
            Para_4 = getValue(mFormData.TableData.Rows[mFormData.Count][6]);
            Para_5 = getValue(mFormData.TableData.Rows[mFormData.Count][7]);
            Para_6 = getValue(mFormData.TableData.Rows[mFormData.Count][8]);
            if (mFormData.Count== mFormData.TableData.Rows.Count - 1)
            { 
                mFormData.Exit = true;
                loop = true;
                this.mForm.Close();
                return;     
            }  
              mFormData.Count++;     
              loop = mFormData.Loop;
            return;
        }

        public void Dispose()
        {
            if (this.mForm != null)
            {
                this.mForm.Dispose();
                this.mForm = null;
            }
            //throw new NotImplementedException();
        }
        private double getValue(object cell)
        {
            if (cell != null)
            {
        if  (string.IsNullOrEmpty(cell.ToString()))
            {
                return 0;
            }
            else
            {
                return double.Parse(cell.ToString());
            }
            }
            else
            {
                return 0;
            }
             
        }
    }



}
