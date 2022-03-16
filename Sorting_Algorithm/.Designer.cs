namespace Sorting_Algorithm
{
    using System;
    partial class Sorts
    {
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.TrackBar arraySize;
        private System.Windows.Forms.Label arraySizeLabel;
        private System.Windows.Forms.Label sliderAmountLabel;
        private System.Windows.Forms.Button generateArray;
        private System.Windows.Forms.TextBox randomArrayDisplay;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private int[] randomNums;
        private bool sorted = false;


        private System.Windows.Forms.Button bubbleSortBtn;
        private System.Windows.Forms.Button quickSortBtn;
        private System.Windows.Forms.TextBox sortingOutputTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox searchOutputTxtbox;
        private System.Windows.Forms.Button binarySearchBtn;
        private System.Windows.Forms.Button LinearSearchBtn;
        private System.Windows.Forms.TextBox searchCriteraTxtbox;
        Random rnd = new Random();

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sortingOutputTxt = new System.Windows.Forms.TextBox();
            this.logout = new System.Windows.Forms.Button();
            this.arraySize = new System.Windows.Forms.TrackBar();
            this.arraySizeLabel = new System.Windows.Forms.Label();
            this.sliderAmountLabel = new System.Windows.Forms.Label();
            this.generateArray = new System.Windows.Forms.Button();
            this.randomArrayDisplay = new System.Windows.Forms.TextBox();
            this.bubbleSortBtn = new System.Windows.Forms.Button();
            this.quickSortBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchOutputTxtbox = new System.Windows.Forms.TextBox();
            this.binarySearchBtn = new System.Windows.Forms.Button();
            this.LinearSearchBtn = new System.Windows.Forms.Button();
            this.searchCriteraTxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sortingOutputTxt
            // 
            this.sortingOutputTxt.BackColor = System.Drawing.Color.White;
            this.sortingOutputTxt.Enabled = false;
            this.sortingOutputTxt.Location = new System.Drawing.Point(12, 129);
            this.sortingOutputTxt.Multiline = true;
            this.sortingOutputTxt.Name = "sortingOutputTxt";
            this.sortingOutputTxt.ReadOnly = true;
            this.sortingOutputTxt.Size = new System.Drawing.Size(495, 70);
            this.sortingOutputTxt.TabIndex = 6;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.logout.Location = new System.Drawing.Point(543, 264);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 0;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // arraySize
            // 
            this.arraySize.Location = new System.Drawing.Point(115, 18);
            this.arraySize.Maximum = 100;
            this.arraySize.Minimum = 2;
            this.arraySize.Name = "arraySize";
            this.arraySize.Size = new System.Drawing.Size(203, 45);
            this.arraySize.TabIndex = 1;
            this.arraySize.Value = 2;
            this.arraySize.Scroll += new System.EventHandler(this.ArraySize_Scroll);
            // 
            // arraySizeLabel
            // 
            this.arraySizeLabel.AutoSize = true;
            this.arraySizeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.arraySizeLabel.ForeColor = System.Drawing.Color.White;
            this.arraySizeLabel.Location = new System.Drawing.Point(76, 0);
            this.arraySizeLabel.Name = "arraySizeLabel";
            this.arraySizeLabel.Size = new System.Drawing.Size(291, 18);
            this.arraySizeLabel.TabIndex = 2;
            this.arraySizeLabel.Text = "Choose size of random array to sort";
            // 
            // sliderAmountLabel
            // 
            this.sliderAmountLabel.AutoSize = true;
            this.sliderAmountLabel.Location = new System.Drawing.Point(320, 22);
            this.sliderAmountLabel.Name = "sliderAmountLabel";
            this.sliderAmountLabel.Size = new System.Drawing.Size(13, 13);
            this.sliderAmountLabel.TabIndex = 3;
            this.sliderAmountLabel.Text = "2";
            // 
            // generateArray
            // 
            this.generateArray.BackColor = System.Drawing.Color.White;
            this.generateArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateArray.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.generateArray.Location = new System.Drawing.Point(434, 8);
            this.generateArray.Name = "generateArray";
            this.generateArray.Size = new System.Drawing.Size(73, 31);
            this.generateArray.TabIndex = 4;
            this.generateArray.Text = "Create";
            this.generateArray.UseVisualStyleBackColor = false;
            this.generateArray.Click += new System.EventHandler(this.GenerateArray_Click);
            // 
            // randomArrayDisplay
            // 
            this.randomArrayDisplay.BackColor = System.Drawing.Color.White;
            this.randomArrayDisplay.Enabled = false;
            this.randomArrayDisplay.Location = new System.Drawing.Point(12, 53);
            this.randomArrayDisplay.Multiline = true;
            this.randomArrayDisplay.Name = "randomArrayDisplay";
            this.randomArrayDisplay.ReadOnly = true;
            this.randomArrayDisplay.Size = new System.Drawing.Size(495, 70);
            this.randomArrayDisplay.TabIndex = 5;
            // 
            // bubbleSortBtn
            // 
            this.bubbleSortBtn.BackColor = System.Drawing.Color.White;
            this.bubbleSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bubbleSortBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.bubbleSortBtn.Location = new System.Drawing.Point(510, 53);
            this.bubbleSortBtn.Name = "bubbleSortBtn";
            this.bubbleSortBtn.Size = new System.Drawing.Size(119, 31);
            this.bubbleSortBtn.TabIndex = 7;
            this.bubbleSortBtn.Text = "Bubble Sort";
            this.bubbleSortBtn.UseVisualStyleBackColor = false;
            this.bubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // quickSortBtn
            // 
            this.quickSortBtn.BackColor = System.Drawing.Color.White;
            this.quickSortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickSortBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.quickSortBtn.Location = new System.Drawing.Point(510, 92);
            this.quickSortBtn.Name = "quickSortBtn";
            this.quickSortBtn.Size = new System.Drawing.Size(119, 31);
            this.quickSortBtn.TabIndex = 8;
            this.quickSortBtn.Text = "Quick Sort";
            this.quickSortBtn.UseVisualStyleBackColor = false;
            this.quickSortBtn.Click += new System.EventHandler(this.quickSortBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search for a value in the array:";
            // 
            // searchOutputTxtbox
            // 
            this.searchOutputTxtbox.BackColor = System.Drawing.Color.White;
            this.searchOutputTxtbox.Location = new System.Drawing.Point(13, 271);
            this.searchOutputTxtbox.Name = "searchOutputTxtbox";
            this.searchOutputTxtbox.ReadOnly = true;
            this.searchOutputTxtbox.Size = new System.Drawing.Size(495, 20);
            this.searchOutputTxtbox.TabIndex = 11;
            // 
            // binarySearchBtn
            // 
            this.binarySearchBtn.BackColor = System.Drawing.Color.White;
            this.binarySearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binarySearchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.binarySearchBtn.Location = new System.Drawing.Point(12, 234);
            this.binarySearchBtn.Name = "binarySearchBtn";
            this.binarySearchBtn.Size = new System.Drawing.Size(141, 31);
            this.binarySearchBtn.TabIndex = 12;
            this.binarySearchBtn.Text = "Binary Search";
            this.binarySearchBtn.UseVisualStyleBackColor = false;
            this.binarySearchBtn.Click += new System.EventHandler(this.binarySearchBtn_Click);
            // 
            // LinearSearchBtn
            // 
            this.LinearSearchBtn.BackColor = System.Drawing.Color.White;
            this.LinearSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LinearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinearSearchBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LinearSearchBtn.Location = new System.Drawing.Point(166, 234);
            this.LinearSearchBtn.Name = "LinearSearchBtn";
            this.LinearSearchBtn.Size = new System.Drawing.Size(141, 31);
            this.LinearSearchBtn.TabIndex = 13;
            this.LinearSearchBtn.Text = "Linear Search";
            this.LinearSearchBtn.UseVisualStyleBackColor = false;
            this.LinearSearchBtn.Click += new System.EventHandler(this.LinearSearchBtn_Click);
            // 
            // searchCriteraTxtbox
            // 
            this.searchCriteraTxtbox.Location = new System.Drawing.Point(268, 208);
            this.searchCriteraTxtbox.Name = "searchCriteraTxtbox";
            this.searchCriteraTxtbox.Size = new System.Drawing.Size(39, 20);
            this.searchCriteraTxtbox.TabIndex = 10;
            // 
            // Sorts
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(641, 299);
            this.Controls.Add(this.arraySizeLabel);
            this.Controls.Add(this.LinearSearchBtn);
            this.Controls.Add(this.binarySearchBtn);
            this.Controls.Add(this.searchOutputTxtbox);
            this.Controls.Add(this.searchCriteraTxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quickSortBtn);
            this.Controls.Add(this.bubbleSortBtn);
            this.Controls.Add(this.sortingOutputTxt);
            this.Controls.Add(this.randomArrayDisplay);
            this.Controls.Add(this.generateArray);
            this.Controls.Add(this.sliderAmountLabel);
            this.Controls.Add(this.arraySize);
            this.Controls.Add(this.logout);
            this.Name = "Sorts";
            this.Text = "Sorting and Searching";
            this.Load += new System.EventHandler(this.Sorts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ----- ARRAY GENERATION ----- //

        // ARRAY SIZE //
        private void ArraySize_Scroll(object sender, System.EventArgs e)
        {
            //function for slider to customise array size.
            sliderAmountLabel.Text = arraySize.Value.ToString();
        }

        private void Sorts_Load(object sender, System.EventArgs e)
        {
            sliderAmountLabel.Text = arraySize.Value.ToString();
        }

        // GENERATE ARRAY //
        private void GenerateArray_Click(object sender, System.EventArgs e)
        {
            sortingOutputTxt.Text = "";
            randomNums = new int[arraySize.Value];
            //Iterates through array setting each value to a random number.
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rnd.Next(0, 1000);
            }
            randomArrayDisplay.Text = string.Join(", ", randomNums);
            sorted = false;
        }

        // ----- BUBBLESORT ----- //

        // BUBBLESORT PROCESS //
        private void bubbleSort()
        {
            //Inits temp value
            int temp;

            //Iterates through the array
            for (int j = 0; j <= randomNums.Length - 2; j++)
            {
                for (int i = 0; i <= randomNums.Length - 2; i++)
                {
                    //Swaps if next item in array is larger than current.
                    if (randomNums[i] > randomNums[i + 1])
                    {
                        temp = randomNums[i + 1];
                        randomNums[i + 1] = randomNums[i];
                        randomNums[i] = temp;
                    }
                }
            }
            //Sets the textbox to the array values
            sortingOutputTxt.Text = string.Join(", ", randomNums);

        }

        // RUN BUBBLESORT //
        private void BubbleSortBtn_Click(object sender, EventArgs e)
        {
            if (randomNums == null)
            {
                //displays error message to user when no array has been created
                System.Windows.Forms.MessageBox.Show("Please create an array first", "ERROR");
            }
            else
            {
                //performs a bubble sort as defined within the above process
                bubbleSort();
                sorted = true;
            }

        }

        // ----- QUICKSORT ----- //

        // PARTITION DEFINITION //
        private static int Partition(int[] arr, int left, int right)
        {   //defines the pivot used, started at the minimum value passed in
            int pivot = arr[left];

            //decleration of while loop
            while (true)
            {
                //quicksort high-low comparison
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }

                //checks right value is greater than left value
                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        // QUICKSORT PROCESS //
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            //checks right value is greater than left value
            if (left < right)
            {
                //defines the pivot used
                int pivot = Partition(arr, left, right);

                //
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        // RUN QUICKSORT //
        private void quickSortBtn_Click(object sender, EventArgs e)
        {
            if (randomNums == null)
            {
                //error message if array hasn't been created
                System.Windows.Forms.MessageBox.Show("Please create an array first", "ERROR");
            }
            else
            {
                //calls and runs through quicksort process, as defined above
                Quick_Sort(randomNums, 0, randomNums.Length - 1);

                //sets the textbox to sorted array values
                sortingOutputTxt.Text = string.Join(", ", randomNums);
                sorted = true;
            }
        }

        // ----- BINARY SEARCH ----- //

        // BINARY SEARCH PROCESS //
        public string[] BinarySearchDisplay(int key)
        {
            string[] output = new string[2];
            if (sorted)
            {
                //definition of variables needed
                int count = 0;
                int minNum = 0;
                int maxNum = randomNums.Length - 1;

                while (minNum <= maxNum)
                {
                    //definition of the midpoint
                    count += 1;
                    output[1] = count.ToString();
                    int mid = (minNum + maxNum) / 2;

                    //search value = (middle) value
                    if (key == randomNums[mid])
                    {
                        output[0] = mid.ToString();
                        return output;
                    }
                    //chooses new midpoint, lower
                    else if (key < randomNums[mid])
                    {
                        maxNum = mid - 1;
                    }
                    //chooses new midpoint, higher
                    else
                    {
                        minNum = mid + 1;
                    }
                }
                output[0] = "Value not found";
                return output;
            }
            else
            {
                //if array is unsorted, binary search will not run
                System.Windows.Forms.MessageBox.Show("Sort the randomized array first", "Sort Array");
                output[0] = "Error";
                output[1] = "Error";
                return output;
            }

        }

        // RUN BINARY SEARCH //
        private void binarySearchBtn_Click(object sender, EventArgs e)
        {
            int searchValue;
            bool success = Int32.TryParse(searchCriteraTxtbox.Text, out searchValue);
            if (success)
            {
                //runs binary searched, as defined within the above process
                string outputText = "The value: ";
                outputText += searchCriteraTxtbox.Text;
                string[] searchResult = BinarySearchDisplay(searchValue);
                Console.WriteLine(searchResult);

                //value not found message
                if (searchResult[0].Equals("Value not found"))
                {
                    outputText += " cannot be found in the array";
                }
                //other error message
                else if (searchResult[0].Equals("Error"))
                {
                    outputText = "An error has occured";
                }
                //success message, providing location and steps taken
                else
                {
                    outputText += " was found in position " + searchResult[0] + " and took " + searchResult[1] + " steps";
                }
                searchOutputTxtbox.Text = outputText;
            }
            else
            //if search box is empty error message
            {
                System.Windows.Forms.MessageBox.Show("Please enter a number!");
            }

        }

        // ----- LINEAR SEARCH ----- //

        // LINEAR SEARCH PROCESS //
        private string[] linearSearch(int elementSought)
        {
            //declaration of relevant variables
            string[] output = new string[2];

            //deceration of for loop array
            for (int currentElement = 0; currentElement < randomNums.Length; currentElement++)
            {
                //runs through all numbers in the array, if array number = search then this is noted in output variable
                if (randomNums[currentElement] == elementSought)
                {
                    output[0] = currentElement.ToString();
                    output[1] = (currentElement + 1).ToString();
                    return output;
                }
            }
            //if loop cannot find search term
            output[0] = "Value not found";
            return output;
        }

        // RUN LINEAR SEARCH //

        private void LinearSearchBtn_Click(object sender, EventArgs e)
        {
            int searchValue;
            bool success = Int32.TryParse(searchCriteraTxtbox.Text, out searchValue);
            //if number is searched for
            if (success)
            {
                string outputText = "The value: ";
                outputText += searchCriteraTxtbox.Text;
                string[] searchResult = linearSearch(searchValue);
                //value not found error message
                if (searchResult[0].Equals("Value not found"))
                {
                    outputText += " cannot be found in the array";
                }
                //error occured message
                else if (searchResult[0].Equals("Error"))
                {
                    outputText = "An error has occured";
                }
                //success message
                else
                {
                    outputText += " was found in position " + searchResult[0] + " and took " + searchResult[1] + " steps.";
                }
                searchOutputTxtbox.Text = outputText;
            }
            //if number isn't searched for
            else
            {
                //error message
                System.Windows.Forms.MessageBox.Show("Please enter a number!");
            }

        }

        // SYSTEM LOGOUT //
        private void Logout_Click(object sender, System.EventArgs e)
        {
            //function for logging user out.
            var logout = new LogIn();
            logout.Show();
            this.Close();
        }
    }
}




