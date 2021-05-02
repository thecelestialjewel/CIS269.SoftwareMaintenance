using System;
using System.Windows.Forms;

namespace Final1
{
    /*
     Christine Jordan
    4.22.2021
    CIS 269 Task 3 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        
    // ***** BEGIN LOOKING FOR BUGS HERE

    // findSubString
    // searches for a string (needle) within another string (haystack)
    // returns the first index position of the needle in the haystack,
    // or -1 if the needle is not found.
    private int findSubString(string haystack, string needle) //method takes in haystack and a string-CMJ
    {
        // if needle longer than haystack, can't be found
        if (needle.Length > haystack.Length) return -1;
            haystack = haystack.ToLower(); //ERROR FIX: Case sensitive checking 
            needle = needle.ToLower(); //ERROR FIX: Case sensitive checking
     
        // for each step we check if the needle matches
        // the current position
        bool match = false;

        // loop variables
        //deleted int i,j; placed into for loop declaration
        


            // consider all start positions in the haystack
            for (int i = 0; i < haystack.Length; i++) //error (1) set to zero, error (2) remove the -needle.length
            {
                // for each start position, assume the needle matches
                match = true;

                // consider each position in the needle, relative to
                // the current position in the haystack
                for (int j = 0; j < needle.Length; j++) //error (4) change j=0, not j=i
                {
                    // if they don't match, then cancel the match
                    if (haystack[i + j] != needle[j])
                    {
                        match = false; //error (3) haystack[j] to [i]
                        break;
                    }
                }
                // if all position in the needle match the haystack
                // return the current position
                if (match) return i; //ERROR FIX: changed to return i instead of j, was returning 3

            } //error (5) curly braces for scope to align logic         
        
        return -1; //ERROR fix: didn't find anything (-1)
        }


    // ***** END LOOKING FOR BUGS HERE
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           int pos = findSubString(txtHayStack.Text, txtNeedle.Text);

            lblResult.Text = pos.ToString();
        }

      

    }
}