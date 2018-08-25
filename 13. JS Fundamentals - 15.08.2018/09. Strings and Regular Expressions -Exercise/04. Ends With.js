function endsWith(str,subStr) {
    console.log(str.substr(str.length-subStr.length,subStr.length)===subStr? "true": "false");
}

endsWith("This sentence ends with fun?","fun?");