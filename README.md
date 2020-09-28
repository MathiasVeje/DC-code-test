# DC-code-test

This project is made and run with VS Code.

I started the exercise by reading the accompanying text, although at first I misread how the strike and spares were counted, which gave me plenty of trouble trying to count the points later.

Firstly, I made some console interaction code to start the project with, which would capture the number of players and their names.

Then, I decided to extract this Player which I saw as having a name and a score, to its own class to have better separation of concerns.

I then went on by trying to have the counting of the score being part of where the score was inputted. Which gave rise to adding more fields on the player like hasSpare.

I didn't like the clutter in the Program class, so I decided that the Player should be a class holding a Score class, where the Score class should be in charge of keeping and adding score. Again to separate concerns. This of course left the player a bit “empty”, but if for example a nickname should be added or a way of ordering drinks and a wallet, the option to extend is there. I also like the abstraction that a player exists as a domain and has a score which is its own domain.

That is more or less as far as I got. Thinks that are missing is:
Validation on all the input, which will crash the program
Handling of the extra roll in the last frame(It is not possible to get 300 pts)
Test in general but of the Score class in particular.

Nice to have:
Extract all the console writing to its own class, and reading.
Overall better algorithms, I am sure I haven't found the best way yet.
Print out a scoreboard at the end of each round.
