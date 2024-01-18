from customtkinter import *

app = CTk()
app.geometry("1000x800")
app.title("ONYX Launcher")

set_appearance_mode("dark")

CTkLabel(master=app, text="ONYX Development", width=100, height=50, font=(CTkFont, 20)).place(relx=0.5, rely=0.05, anchor="center")


tab_view = CTkTabview(master=app, width=750, height=900)
tab_view.pack(padx=20, pady=75, expand=False)
tab_view.add("Games")
tab_view.add("News")
tab_view.add("Settings")
tab_view.add("Account")


btn = CTkButton(master=tab_view.tab("Games"), text="Click Me")
btn.place(relx=0.5, rely=0.5, anchor="center")

news_frame = CTkScrollableFrame(master=tab_view.tab("News"), width=700, height=900)
news_frame.pack(expand=False)


def GenerateNews(set_title):
    new_news = CTkFrame(master=news_frame, width=350, border_color="#242424", border_width=10)
    new_news.pack(expand=False)


GenerateNews("test1")
GenerateNews("test2")
GenerateNews("test3")


app.mainloop()