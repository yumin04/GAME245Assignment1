# GAME245Assignment1

## FILES
#### Game.cs
- ProcessAnswer(bool isCorrect) -> Updates the score and checks for the next question
- CheckIfQuestionLeft() -> Goes to next question or ends the game
- Reset() -> Resets the game state
- QuitApplication() -> Exits the game out of Unity

#### QuesetionGenerator.cs
- GetNextQuestion() -> Returns a tuple (x, y, answerA, answerB, answerC)
- CheckForCorrectAnswer(int i) -> Returns true if index i is the correct one

#### GameMediator.cs
- StartButtonClicked() -> Starts the game and timer
- AnswerButtonClicked(int i) -> Checks answer, ends timer, and updates game
- GenerateNextQuestion() -> Gets a new question and updates the UI
- EndGame(int correct) -> Shows the end screen with score
- RestartButtonClicked() -> Resets the game and starts again
- QuitButtonClicked() -> Exits the game

#### UI.cs
- DisplayStartScreen(), DisplayGameScreen(), DisplayEndScreen(int) -> Switches visible UI screen
- MoveToNextQuestion(...) -> Shows new question and answer options
- ChangeCountdownText(int) -> Updates the countdown text on the correct screen
- Button handlers like OnClickAnswerButton(int) and OnClickStartButton() connect UI to logic

#### Cowndown.cs
- StartGameTimer() -> Starts a short 5-second start timer
- StartRoundTimer() -> Starts a 10-second timer for each question
- RunTimer(int) -> Coroutine that counts down and notifies GameMediator each second
- EndTimer() -> Stops all running timers
