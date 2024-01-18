from customtkinter import *
from PIL import Image

print("launching launcher")

def AddTab(form, title): form.add(title)

app = CTk()
app.geometry("1000x800")
app.title("ONYX Launcher")

set_appearance_mode("dark")

hh_logo = Image.open("img/hell_hotel_logo.png")
rd_logo = Image.open("img/ragdoll_destroyers_logo.png")
d_logo = Image.open("img/discord_logo.png")
gh_logo = Image.open("img/github_logo.png")

title = CTkLabel(app, text="ONYX Game Launcher", font=(CTkFont, 20)).place(relx=0.5, rely=0.05, anchor="center")

master_tabs = CTkTabview(master=app, width=750, height=900)
master_tabs.pack(padx=20, pady=75, expand=False)
AddTab(master_tabs, "Games")
AddTab(master_tabs, "Settings")
AddTab(master_tabs, "Account")
AddTab(master_tabs, "Downloads")

games_tabs = CTkTabview(master=master_tabs.tab("Games"), width=750, height=800)
games_tabs.pack(expand=False)
AddTab(games_tabs, "Hell Hotel")
AddTab(games_tabs, "Ragdoll Destroyers")

hh_image = CTkLabel(games_tabs.tab("Hell Hotel"), image=CTkImage(dark_image=hh_logo, light_image=hh_logo, size=(250, 250)), text="").place(relx=0, rely=0)
hh_image = CTkLabel(games_tabs.tab("Ragdoll Destroyers"), image=CTkImage(dark_image=rd_logo, light_image=rd_logo, size=(250, 250)), text="").place(relx=0, rely=0)

btn_discord = CTkButton(master=master_tabs.tab("Settings"), text="Join Discord", image=CTkImage(dark_image=d_logo, light_image=d_logo, size=(31, 24)), fg_color="#000000", border_color="#7289da", text_color="#7289da", border_width=3, corner_radius=20, font=(CTkFont, 15)).place(relx=0.025, rely=0)
btn_github = CTkButton(master=master_tabs.tab("Settings"), text="GitHub", image=CTkImage(dark_image=gh_logo, light_image=gh_logo, size=(24, 24)), fg_color="#aaaaaa", text_color="#000000", border_color="#000000", border_width=4, corner_radius=20, font=(CTkFont, 15)).place(relx=0.025, rely=0.075)

app.mainloop()