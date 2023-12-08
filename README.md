# Console Game Project - 21

## Overview

Welcome to the Console Game Project - 21! This simple console-based card game is designed to exercise code structuring, naming conventions, and provide a foundation for future enhancements. While the current version may not be fully functional for gameplay, it is structured in a way that allows for easy modification and expansion.

## Features

- **Modular Code Structure**: The project is organized into classes and methods, promoting code modularity and readability.
  
- **Namespace Organization**: Utilizes namespaces to logically group related classes, enhancing code organization.

- **Card Handling**: Implements basic card handling, including card representation and deck manipulation.

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

**Encapsulation:** Consider making private fields in classes truly private and utilize properties for better encapsulation.

**Error Handling:** Implement error handling mechanisms, especially when dealing with external input or deck interactions.

**Comments and Documentation:** Add comments to clarify complex algorithms, and provide documentation for classes and methods.

**User Interface Enhancement:** Continue improving the user interface for a more engaging experience.


## License

This project is licensed under the MIT License - see the LICENSE file for details. //WIP



Feel free to reach out if you have any questions or suggestions. Happy coding!


