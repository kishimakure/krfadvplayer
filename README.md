# Kirara Fantasia ADV Player
## Usage

1. Download the Player: Go to the [Releases](../../releases) page of this repository, download the latest compiled player `.zip` file, and extract it to your computer.
2. Download the Asset Library: Download the full dynamic asset library from either of the source below:
  * MEGA: [Part 1](https://mega.nz/file/LGQjCZQI#Nci3QmkfDCw6-_TlpZ0ABaa1iJVyRzYe3iZ8Ru7wy2Y) [Part 2](https://mega.nz/file/bGIVgRYL#99_RydFCMMwb-cMlHUamKCvNUnV5AbJyHEKt2wHSXu0) [Part 3](https://mega.nz/file/DeR3FSwI#Vu5DqKQqRYRv_AHglnXKhSMOmI_4cHMjnm_e0k7Viw4)
  * Google Drive: [Download Here](https://drive.google.com/file/d/1D15zyme7qpFMLJEZ8b0pgIub14ija7hm)
3. Extract Assets: Extract the asset library to a preferred location on your local drive.
4. Locate the Config File: Inside your extracted player folder, navigate to `Assets/StreamingAssets/` and open `Params.json` with any text editor (like Notepad).
5. Link the Assets: Find the `"Host"` field and enter the **absolute local path** pointing to the `adv` folder inside your extracted asset library. **Make sure to use the `file://` prefix.**
   * *Example:* `"Host": "file://D:/path/to/adv"`
6. Save `params.json` and launch the player executable (`.exe`).

Refer to the [ADVList](./ADVList.xlsx) for ADVIDs.
Check out my [Bilibili article](https://www.bilibili.com/opus/1071238068570161192) for more info or krfadveditor.
