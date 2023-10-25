const { REST, Routes } = require('discord.js');
const fs = require('fs');
const path = require('path');
const { clientId, token} = require('./config.json');

const commands = [];
const commandFoldersPath = path.join(__dirname, 'commands');
const commandFolders = fs.readdirSync(commandFoldersPath);

for (const folder of commandFolders) {
    const commandsPath = path.join(commandFoldersPath, folder);

     // Check if the path is a directory before proceeding
     if (fs.statSync(commandsPath).isDirectory()) {
        const commandFiles = fs.readdirSync(commandsPath).filter(file => file.endsWith('.js'));
    for (const file of commandFiles) {
        const command = require(path.join(commandsPath, file));
        if (command.data) {
            commands.push(command.data.toJSON());
        }
    }
}else if (commandsPath.endsWith('.js')) {
    // Here, handle files directly inside the 'commands' directory
    const command = require(commandsPath);
    if (command.data) {
        commands.push(command.data.toJSON());
    }
}
}

const rest = new REST({ version: '10' }).setToken(token);

(async () => {
    try {
        console.log(`Started refreshing ${commands.length} application (/) commands.`);

        const data = await rest.put(
            Routes.applicationCommands(clientId), // Change this line for global commands
            { body: commands },
        );

        console.log(`Successfully reloaded ${data.length} application (/) commands.`);
    } catch (error) {
        console.error(error);
    }
})();
