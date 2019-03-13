using System;
using System.Collections.Generic;



namespace Version_1_C
{
    [Serializable()] 
    public class clsWorksList : List<clsWork>
    {
        private byte sortOrder;

        public byte SortOrder { get => sortOrder; set => sortOrder = value; }

        public void AddWork(char prChoice)
        {
            clsWork lcWork = clsWork.NewWork(prChoice);
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }
        
        public void DeleteWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                this.RemoveAt(prIndex);
            }
        }
        
        public void EditWork(int prIndex)
        {
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsWork lcWork = this[prIndex];
                lcWork.EditDetails();
            }
            else
            {
                clsCheckErrorMsg.MsgTrue = false;
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsWork lcWork in this)
            {
                lcTotal += lcWork.Value;
            }
            return lcTotal;
        }

         public void SortByName()
         {
             Sort(clsNameComparer.NameCompare);
         }
    
        public void SortByDate()
        {
            Sort(clsDateComparer.DateCompare);
        }
    }
}
