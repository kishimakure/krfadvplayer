# Kirara Fantasia ADV Player
## Usage

1. Download the Player: Go to the [Releases](../../releases) page of this repository, download the latest compiled player `.zip` file, and extract it to your computer.
2. Download the Asset Library(~5GB): This repository does not provide direct links. You can find it somewhere.
3. Extract Assets: Extract the asset library to a preferred location on your local drive.
4. Locate the Config File: Inside your extracted player folder, navigate to `krfadvplayer_Data/StreamingAssets/` and open `Params.json` with any text editor (like Notepad).
5. Link the Assets: Find the `"Host"` field and enter the **absolute local path** pointing to the `adv` folder inside your extracted asset library. **Make sure to use the `file://` prefix.**
   * *Example:* `"Host": "file://D:/path/to/adv"`
6. Save `Params.json` and launch the player executable (`.exe`).

Refer to the [ADVList](./ADVList.xlsx) for ADVIDs.
Check out my [Bilibili article](https://www.bilibili.com/opus/1071238068570161192) for more info or krfadveditor.
