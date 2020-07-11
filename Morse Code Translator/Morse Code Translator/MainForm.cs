
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Morse_Code_Translator
{
	/// <summary>
	/// This is where the main mechanics of the app are kept. Mainform is what actually starts the app and 
	/// Keeps it running until the user closes the app.
	/// ButtonClick is a function called whenever the TRANSLATE button is pressed and translates the input and displays it
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// This function uses a dictionary to go through every character inputted by the user and translates it to morse
		/// code. Gives the user an error if they enter a character that does not have a morse code translation.
		/// </summary>
		void ButtonClick(object sender, EventArgs e)
		{
			Dictionary<char,string> MorseDict=new Dictionary<char, string>(){
			{'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},{'f',"..-."},
			{'g',"--."},{'h',"...."},{'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},
			{'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},{'q',"--.-"},{'r',".-."},
			{'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
			{'y',"-.--"},{'z',"--.."},{' ',"/"},{'1',".----"},{'2',"..---"},{'3',"...--"},
			{'4',"....-"},{'5',"....."},{'6',"-...."},{'7',"--..."},{'8',"---.."},{'9',"----."},
			{'0',"-----"},{'.',".-.-.-"},{',',"--..--"},{'?',"..--.."},{'/',"-..-."},
			{'-',"-....-"},{'(',"-.--."},{')',"-.--.-"},{'!',"-.-.--"},{':',"---..."},
			{';',"-.-.-."},{'=',"-...-"},{'+',".-.-."},{'_',"..--.-"},{'"',".-..-."},
			{'@',".--.-."},{'\'',".----."}
			};
			string phrase=TB.Text;
			String translated="";
			try{
				foreach (char i in phrase)
				{
					if (i>=65 && i<=90){
						translated+=MorseDict[char.ToLower(i)]+" ";
					}
					else{
						translated+=MorseDict[i]+" ";
					}
				}
				Translation.Text=translated;
			}
			catch (Exception error)
			{
				Translation.Text="Sorry, one of the characters you used does not have a morse code translation. Please try again.";
			}
		}
	}
}
