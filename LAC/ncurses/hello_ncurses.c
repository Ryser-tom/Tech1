#include <stdlib.h>
#include <ncurses.h>


int main(){
    initscr();
    printw("Hello ncurses !");
    refresh();    
    getch();
    endwin();
    
    return EXIT_SUCCESS;
}