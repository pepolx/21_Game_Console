# Console Game Project - 21

## Overview

Welcome to the Console Game Project - 21! This simple console-based card game is designed to exercise code structuring, naming conventions, and provide a foundation for future enhancements. While the current version may not be fully functional for gameplay, it is structured in a way that allows for easy modification and expansion.

## Features

- **Modular Code Structure**: The project is organized into classes and methods, promoting code modularity and readability.
- **Console-Based Interface:** Simple and intuitive command-line interactions for gameplay.
- **Computer Dealer:** Play against an automated dealer that follows the standard rules of the 21 game.
- **Card Handling**: Implements basic card handling, including card representation and deck manipulation.

## Purpose

This project serves as a learning journey to enhance my understanding of console applications in C#. It aims to demonstrate:
- Proficiency in fundamental C# concepts and control structures.
- Effective use of object-oriented programming (OOP) principles.
- The ability to design and implement game logic in a console environment.


## Getting Started

Follow these steps to get the project up and running on your local machine:

1. **Clone the Repository**:

    ```bash
    git clone https://github.com/pepolx/21_Console_Game.git
    cd 21_Console_Game
    ```

    Ensure that .NET is installed on your machine.

## Code Highlights

### Deck Class

The `Deck` class handles the creation, shuffling, and management of the game deck.

```csharp
public class Deck
{
    private readonly int _decksPlaying;
    private readonly int _cardsPerDeck = 52;
    private List<Card> _deckOfCardsInGame = null!;
    // ... (other methods and properties)
}
```

### Player Class

The `Player` class manages the player's hand, card values, and provides methods for interacting with the deck.

```csharp
public class Player
{
    private List<Card> _playerHand;
    private int _playerBalance;
    public int ValueOfCards { get; private set; }
    // ... (other methods and properties)
}
```

### Dealer Class

The `Dealer` class represents the dealer in the game, handling the dealer's hand and card values.

```csharp
Copy code
public class Dealer
{
    private List<Card> _dealerHand;
    public int ValueOfCards { get; private set; }
    // ... (other methods and properties)
}
```

## Suggestions for Improvement

**User Interface Enhancement:** Continue improving the user interface for a more engaging experience.
- **Multiplayer Support:** Adding the capability for multiple human players to play against the dealer.
- **Enhanced Strategy:** Incorporating more advanced dealer strategies and player choices.
- **Score History:** Implementing a feature to track and display the score history of the player over multiple rounds.

## Learning Outcomes

Through the development of the 21 Game Console, I aim to solidify my skills in:
- Console application development with C#.
- Implementing clean and maintainable code with proper class structures.
- Managing the project lifecycle and version control with git and GitHub.





Feel free to reach out if you have any questions or suggestions. Happy coding!


