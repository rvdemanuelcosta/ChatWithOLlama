# ChatWithLlama
# Ollama Model Chat C# Application

This is a C# Windows Forms application that allows users to run and chat with Ollama's models. The application currently supports text-only models, vision functionality is not supported.

## Features

* **Text-based Chat**: Interact with Ollama's text models through a user-friendly interface.
* **User-Friendly Interface**: A easy to use application, no need to run commands.
* **Compact Interface**: The chat window was developed to take little screen space.
* **Aways on top**: The user can set the chat window to be aways on top.


## Known problems
* **No chat history**: currently there is no way to save the chat messages, once the program is closed
	it will erase the chat.

## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or later
- Visual Studio (optional, but recommended for development)
- Ollama.
- Ollama compatible model.

### Installation

1. Clone this repository to your local machine:
   ```git clone https://github.com/rvdemanuelcosta/ChatWithOLlama.git ```
2. Open the solution file (OllamaChatApp.sln) in Visual Studio.

3.	Build and run the project:
	* Press F5 or click on the "Start" button in Visual Studio.
	* Alternatively, you can build the project using the command line:
	* ```dotnet build OllamaChatApp.sln```
	1. Run the application:
	```dotnet run --project OllamaChatApp/OllamaChatApp.csproj```
	1. 
# Usage
### Before running this application, you will need to:
1. Have Ollama installed.
	You can download it from [Ollama's  official website](https://ollama.com/)
1. Start Ollama.
1. Download any model compatible with ollama.
	You can download Ollama models from [ollama's models](https://ollama.com/search) page.
	use the command ```ollama pull "replace_with_your_model_name"``` to download a model.
#### Loading a model
1. Run this application.
1. Click on the settings button on the top left of the main window.
1. Select a model from the combo box.
1. Click in the run/load model button to run the model.
	**If everything is working correctly the model name should be visible on the top of the main window in green color.**
1. Click on the settings button (step 2) or on the x of the settings window to close it.
1. Enter your text in the input field at the bottom of the window.
1. Click the "Send" button or press Enter to submit your text, wait for the ollama model response.
The model's response will be displayed on the main window.

### Contributing
Contributions are welcome! If you have any suggestions, bug reports, or feature requests, please open an issue on the GitHub repository.

License
This project is licensed under the **GNU (General Public License) v3**.0 License - see the LICENSE file for details.