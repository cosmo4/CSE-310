from tkinter import *

root = Tk()

e = Entry(root, width=50)

e.pack()

e.insert(0, "Enter your name:")

def myClick():
    greet = "Hello " + e.get()
    myLabel = Label(root, text=greet)
    myLabel.pack()


myButton = Button(root, text="Click Me", padx=50, command=myClick, bg="#d0d0d0")

myButton.pack()

# Event Loop
root.mainloop()