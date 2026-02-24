# Kirara Fantasia ADV Player
## Usage

1. Download the Player: Go to the [Releases](../../releases) page of this repository, download the latest compiled player `.zip` file, and extract it to your computer.
2. Download the Asset Library: Download the full dynamic asset library from [MEGA]https://mega.nz/file/LGQjCZQI#Nci3QmkfDCw6-_TlpZ0ABaa1iJVyRzYe3iZ8Ru7wy2Y [MEGA]https://mega.nz/file/bGIVgRYL#99_RydFCMMwb-cMlHUamKCvNUnV5AbJyHEKt2wHSXu0 [MEGA]https://mega.nz/file/DeR3FSwI#Vu5DqKQqRYRv_AHglnXKhSMOmI_4cHMjnm_e0k7Viw4 and extract it to a preferred location on your local drive.
3. Locate the Config File: Inside your extracted player folder, navigate to `Assets/StreamingAssets/` and open `Params.json` with any text editor (like Notepad).
4. Link the Assets: Find the `"Host"` field and enter the **absolute local path** pointing to the `adv` folder inside your extracted asset library. **Make sure to use the `file://` prefix.**
   * *Example:* `"Host": "file://D:/path/to/adv"`
5. Save `params.json` and launch the player executable (`.exe`).
