from customtkinter import *

app = CTk()
app.geometry("500x400")

set_appearance_mode("dark")

tabView = CTkTabview(master=app, height=390, width=490)
tabView.pack()

tabView.add("Games")
tabView.add("News")
tabView.add("Settings")
tabView.add("Account")

btn = CTkButton(master=tabView.tab("Games"), text="Click Me", corner_radius=16)
btn.place(relx=0.5, rely=0.5, anchor="center")

app.mainloop()