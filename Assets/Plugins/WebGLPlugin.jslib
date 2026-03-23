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
  GetCustomAdvScript: function (advId) {
    var data = localStorage.getItem("customAdvScripts");
    var result = "";
    if (data) {
        try {
            var map = JSON.parse(data);
            var entry = map[advId];
            if (entry && entry.scriptData) result = entry.scriptData;
        } catch (e) {}
    }
    var bufferSize = lengthBytesUTF8(result) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(result, buffer, bufferSize);
    return buffer;
  },
  GetCustomAdvScriptText: function (advId) {
    var data = localStorage.getItem("customAdvScripts");
    var result = "";
    if (data) {
        try {
            var map = JSON.parse(data);
            var entry = map[advId];
            if (entry && entry.scriptTextData) result = entry.scriptTextData;
        } catch (e) {}
    }
    var bufferSize = lengthBytesUTF8(result) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(result, buffer, bufferSize);
    return buffer;
  },
  GetCustomAdvScriptFileNames: function (advId) {
    var data = localStorage.getItem("customAdvScripts");
    var result = "";
    if (data) {
        try {
            var map = JSON.parse(data);
            var entry = map[advId];
            if (entry) result = JSON.stringify({ scriptName: entry.scriptName, scriptTextName: entry.scriptTextName });
        } catch (e) {}
    }
    var bufferSize = lengthBytesUTF8(result) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(result, buffer, bufferSize);
    return buffer;
  },
  ReturnToMenu: function () {
    if (window.onUnityExit) {
        window.onUnityExit();
    }
  }
});