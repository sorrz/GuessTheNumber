## Guess the Number

#### A School Project in ProgFö50 - Syne22Lin @ TucSweden

-----------------------------------

The assignment:

### Object Oriented Programming

#### Guess the Number

##### G:<br>

[x]Use the example text for the "GUI"<br>
[x]Random numbers between 1-100 (not 0-101)<br>
[x]Input of something else then a INT number should be handled (TryParser()?)<br>
[x]Program should count numberOfGuesses that are valid INT Numbers<br>
[x]Faulty guesses should not increase the count<br>
[x]Hint that shows after each guess (lower, higher)<br>
[x]On the correct guess:<br>
[x]Print a "Correct text" and display the number of tries it took.<br>
[-]Prompt a question to check if the player wants to guess again<br>
[x]Switched to a Menu as per The checkpoint in VG<br>
[-]Faulty answers need to be handled (nope instead of a NEJ is not valid) and should re-prompt the question.<br>
[x]Handeled by the menu<br>

#### VG:<br>

[x]Make the program use a "Low Score List" that saves the 5 lowest scores in a file.<br>
[x]If you hit a lowscore, you should be prompted to enter your name and your result should be saved to the corresponding
spot on the list.<br>
[x]In the Meny you should have the option to show the lowscore-list, which should display it on the screen.<br>
[x]Date, Time, Name and Guesses should be saved for each low-score entry.<br>
[x]Instead of "play again?", implement a menu<br>
[x]Error handling, don't crash in menu's etc if there's a faulty input<br>

TODO:<br>
--Game Round<br>
[x]Write the Logic for Lower or Higher, output from Methods that fit<br>
[-]While Loop Running while !true, set to true when number is hit<br>
[x]Fixed with a check instead<br>
[-]Make a splash screen<br>
--App<br>
[-]Fix the Menu<br><br>
[-]Needs a graphical update<br>
--Score<br>
[x]Create Objects of the Score Class for each Round<br>
[x]Read all lines in the File and convert to objects to save to a list with the type Score<br>
[x]Sort list.Asc by score and save the top five to the File upon closing<br> 