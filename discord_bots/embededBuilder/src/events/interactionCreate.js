const { EmbedBuilder, MessageActionRow, MessageButton,ButtonBuilder,ActionRowBuilder, InteractionCollector , AttachmentBuilder} = require('discord.js');
const {footer,footerIcon,color} = require('../config.json')



module.exports = {
  name: 'interactionCreate',
  async execute(interaction, client) {
    if (!interaction.isCommand() && !interaction.isModalSubmit() && !interaction.isButton()) return;

    // Handle command interactions
    if (interaction.isCommand()) {
      try {
        const command = require(`../commands/${interaction.commandName}.js`);
        await command.execute(interaction);
      } catch (error) {
        console.error(error);
        await interaction.reply({ content: 'An error occurred while executing this command.', ephemeral: true });
      }
    }

    // Handle modal submission
  if (interaction.isModalSubmit()) {
  if (interaction.customId === 'embedModal') {
    const EmbedName = interaction.components[0].components[0].value;
    const Description =interaction.components[1].components[0].value;
    const thumbnail = interaction.components[2].components[0].value;
    const attachment = interaction.components[3].components[0].value;

    const fileAttachment = new AttachmentBuilder(attachment);

    const newColor = parseInt(color)


    // Create the poll embed using EmbedBuilder
    const newEmbed = new EmbedBuilder()
      .setTitle(EmbedName)
      .setDescription(Description)
      .setColor(newColor)
      .setTimestamp()
      .setThumbnail(thumbnail)
      .setAuthor({ name: interaction.user.username, iconURL: interaction.user.avatarURL(), url: 'https://discord.js.org' })
      .setFooter({ text: `${footer}`, iconURL: `${footerIcon}` });

     // Send the poll embed and buttons
     await interaction.channel.send({ embeds: [newEmbed], files: [fileAttachment]});
     await interaction.reply({ content: 'New Embed Created', ephemeral: true });
  }
    }
  }
}