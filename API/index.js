const express = require('express')
const Router = require("./routes/routes")

const PORT = process.env.PORT || 8080

const app = express()

app.use(express.json())
app.use('/api', Router)

app.listen(PORT, () => console.log(`server started on port ${PORT}`))