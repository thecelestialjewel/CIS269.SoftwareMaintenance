using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final1
{
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
    private int findSubString(string haystack, string needle)
    {
        // if needle longer than haystack, can't be found
        if (needle.Length > haystack.Length) return -1;
     
        // for each step we check if the needle matches
        // the current position
        bool match = false;

        // loop variables
        int i, j;

        // consider all start positions in the haystack
        for (i = 1; i < haystack.Length - needle.Length; i++)
        
            // for each start position, assume the needle matches
            match = true;

            // consider each position in the needle, relative to
            // the current position in the haystack
            for (j = i; j < needle.Length; j++)
            {
                // if they don't match, then cancel the match
                if (haystack[j] != needle[j]) match = false;
            }

            // if all position in the needle match the haystack
            // return the current position
            if (match) return j;
                    
        
        return 0;
    }


    // ***** END LOOKING FOR BUGS HERE
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
           int pos = findSubString(txtHayStack.Text, txtNeedle.Text);

            lblResult.Text = pos.ToString();
        }

      

    }
}