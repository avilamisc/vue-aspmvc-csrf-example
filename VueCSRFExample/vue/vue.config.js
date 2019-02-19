const path = require('path')

module.exports = {
    indexPath: path.resolve(__dirname, 'dist/Views/example/index.cshtml'),
    outputDir: path.resolve(__dirname, 'dist/'),
    assetsDir: 'Content',
    publicPath: '/',
}