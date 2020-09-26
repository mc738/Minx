function FileSaveAs(filename, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename + ".pdf";
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}

function FileSaveAsWithExt(filename, ext, bytesBase64) {
    var link = document.createElement('a');
    link.download = filename + ext;
    link.href = "data:application/octet-stream;base64," + bytesBase64;
    document.body.appendChild(link); // Needed for Firefox
    link.click();
    document.body.removeChild(link);
}