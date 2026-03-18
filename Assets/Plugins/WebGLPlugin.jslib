mergeInto(LibraryManager.library, {
  SetWebTitle: function (title) {
    document.title = UTF8ToString(title); 
  },
  GetPlaylistFromLocalStorage: function () {
    var playlistStr = localStorage.getItem("ADVIDs");
    if (playlistStr === null) {
        playlistStr = "[]"; 
    }
    var bufferSize = lengthBytesUTF8(playlistStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(playlistStr, buffer, bufferSize);
    return buffer;
  },
  ClearPlaylistInLocalStorage: function () {
    localStorage.removeItem("ADVIDs");
  },
  ReturnToMenu: function () {
    if (window.onUnityExit) {
        window.onUnityExit();
    }
  }
});