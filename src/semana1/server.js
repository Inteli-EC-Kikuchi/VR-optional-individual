const express = require('express');

const app = express();

// Enable image loading from the current directory
app.use(express.static(__dirname));

app.get('/', (req, res) => {
    // Render the a.html file
    res.sendFile(__dirname + '/index.html');
    }
);

app.get('/vr', (req, res) => {
    // Render the a.html file
    res.sendFile(__dirname + '/vr.html');
    }
);

app.get('/ar', (req, res) => {
    // Render the a.html file
    res.sendFile(__dirname + '/ar.html');
    }
);

app.listen(3000, () => {
    console.log('Server is running on port 3000');
});