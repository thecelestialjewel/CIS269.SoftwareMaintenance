using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _42dayrange
//Christine Jordan 
//4.23.2021
//CIS 269: Week 2 Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /* 1. Create a function which looks at the checkboxes
         * on the form and returns a sequence (array/list/etc) of the days
         * selected.  The return must be a sequence of enumeration
         * values.  The return sequence must be in day-sorted order,
         * e.g. Monday, ..., Friday, Saturday, Sunday
         * 
         */
        public IEnumerable<Day> GetCheckboxDays()
        {

            // YOU FILL IN HERE
            // Create an array/list/etc of enum values
            // based on the checkboxes on the form.

            List<Day> days = new List<Day>(); //created a list of days
           
            if (chkMonday.Checked)
            {
                days.Add(Day.Monday);
            }
            if (chkTuesday.Checked)
            {
                days.Add(Day.Tuesday);
            }
            if (chkWednesday.Checked)
            {
                days.Add(Day.Wednesday);
            }
            if (chkThursday.Checked)
            {
                days.Add(Day.Thursday);
            }
            if (chkFriday.Checked)
            {
                days.Add(Day.Friday);
            }
            if (chkSaturday.Checked)
            {
                days.Add(Day.Saturday);
            } 
            if (chkSunday.Checked)
            {
                days.Add(Day.Sunday);
            }
            return days;

        }

        /* 2. and 3. 
         * Here is a BROKEN! function which accepts a collection
         * of enumerated day values and calculates the
         * date range.  Fix this function!
         * 
         * There is ONE bug in this function.
         * 
         * You may assume the input will
         * be in sorted order.   
         * Reference only the parameter days, not
         * the checkboxes.
         * 
         * The date range is a string which lists the
         * names of each selected day, separated by
         * a comma.  If three or more consecutive days
         * are selected, however, use a dash to specify the range
         * from the first to the last.
         * 
         */
        public string ToDayRange(Day[] days) //cntrl + click 'Day' to see enum values -CMJ
        {
            // YOU FIX STARTING HERE

            // result string
            string r = "";

            // start at the first day
            int pos = 0;

            // look through all the days
            while (pos < days.Length)
            {
                // find a sequence!
                // offset (next value in sequence)
                int off = 1;
                // start of sequence is always current day
                string seq = days[pos].ToString();

                // increase the offset as long as the offset
                // does not exceed the number of days
                // and the days are sequential
                while (pos + off < days.Length && days[pos + off] == days[pos] + off)
                    off++;

                // if the offset is three or more days
                if (off > 2)
                {
                    // use a dash to separate the first and last
                    seq += "-" + days[pos + off - 1];
                    // skip over the intermediate days
                    pos = pos + off; //FIXED CODE TO MOVE POSITION TO KEEP UP WITH OFFSET -CMJ
                }
                else pos++; // otherwise move one step

                // add a comma if needed
                if (r.Length > 0) r += ", ";
                r += seq;
            }
            return r;

            // END FIXING HERE


        }




        // no need to change this.
        public void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            txtDays.Text = ToDayRange(GetCheckboxDays().ToArray());
        }
    }
}



