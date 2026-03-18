# Number-Duel
## Overview
Number Duel is a turn-based strategy and logic game in which two players compete by selecting from a game board according to a specific rule. The following sections describe the game and its software implementation.
## The Game
In Number Duel, each player takes a turn selecting a number from a randomly generated set of 16 numbers between 1 and 50. The number that the player selects must be either a factor or a multiple of the previous number. The first number is a free pick.
Each number can only be used once, and every move must follow the rule based on the previously selected number. As the game progresses, the available choices become more limited, requiring the players to think ahead and plan their moves carefully. 
The goal of the game is to force the opponent into a position where they have no valid moves remaining. The player who makes the last valid move wins the game. Because each move directly impacts the future options, players must balance selecting strong numbers with limiting their opponent’s opportunities.

