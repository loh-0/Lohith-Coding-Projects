import random 
import copy 
import time

def validate_input(prompt, valid_inputs):
	"""
	Repeatedly ask user for input until they enter an input
	within a set valid of options.

	:param prompt: The prompt to display to the user, string.
	:param valid_inputs: The range of values to accept, list
	:return: The user's input, string.
	"""
	option = input(prompt)
	while option not in valid_inputs:
		print("Invalid input, please try again.")
		option = input(prompt)

	return option

def create_board_k():
	"""
	Prompts user to input columns and rows.
	Creates board with default cell value as 0.

	:return: A 2D list of inputted dimensions.
	"""

	columns = int(input("Enter Columns: "))  # assigns columns required
	rows = int(input("Enter Rows: "))
	board = []
	for row in range(rows):  # we need to use an append feature so the arrays are unique and can be edited

		board.append([0] * columns)  # adds 7 boxes

	return board  # return array

def print_board_k(board):

	"""
	Prints the game board to the console.

	:param board: The game board, 2D list.
	:return: None
	"""

	board_text = """========== Connectk =========

  """
	border_text = ""
	columns = len(board[0])
	row = len(board)
	for i in range(1, columns+1):
		board_text += str(i)
		board_text += "   "

	for i in range(columns):
		border_text += " ---"


	print(board_text)
	for row in board:
		print(border_text)
		for cell in row:
				if cell == 0:
					print("|  ", end=" ")  # a space is added, end print makes sure a new line is not pr qinted underneath
				elif cell !=0:
					print("|", cell, end=" ")

		print("|")
	print(border_text)

def drop_piece_k(board, player, column):
	"""
	Drops a piece into the game board in the given column.
	Please note that this function expects the column index
	to start at 1.

	:param board: The game board, 2D list.
	:param player: The player dropping the piece, int.
	:param column: The index of column to drop the piece into, int.
	:return: True if piece was successfully dropped, False if not.
	"""
	# Implement your solution below
	if board[0][column-1]!= 0: #checking whether it can drop the piece
		ans = False
	else:
		for i in range(len(board)): #placing the piece
			if board[len(board)-1-i][column-1] == 0:
				board[len(board)-1-i][column-1] = player
				break
		ans = True

	return ans			

def execute_player_turn_k(player, board): 
	"""
	Prompts user for a legal move given the current game board
	and executes the move.

	:return: Column that the piece was dropped into, int.
	"""
	# Implement your solution below
	player_no = str(player)
	prompt = 'Player ' + player_no +', please enter the column you would like to drop your piece into: '
	
	#creating list of valid inputs
	valid_inputs = []
	for i in range(len(board[0])):
		valid_inputs += str(i+1)
	
	#chekcing input
	column = int(validate_input(prompt, valid_inputs))

	#placing the piece
	while drop_piece_k(board,player,column) == False:
		print('That column is full, please try again.')
		column = int(validate_input(prompt, valid_inputs))

	return column

def end_of_game_k(board,k):  # Question 6
	"""
    Checks if the game has ended with a winner
    or a draw.

    :param board: The game board, 2D list.
	:param k: the number of pieces to win
    :return: 0 if game is not over, player number if that player wins, -1 if draw.
    """

	if horizontal_win_k(board, k) != False:
		return horizontal_win_k(board, k)
	elif vertical_win_k(board, k) != False:
		return vertical_win_k(board, k)
	elif pos_diagonal_win_k(board, k) != False:
		return pos_diagonal_win_k(board, k)
	elif neg_diagonal_win_k(board, k) != False:
		return neg_diagonal_win_k(board, k)
	else:
		return draw_k(board)


def vertical_win_k(board, k):
	"""
    Checks if the game has ended vertically

    :param board: The game board, 2D list.
	:param k: the number of pieces to win
    :return: player number if win or false if no win  
    """
	consectokens = 0
	for column in range(len(board[0])):
		for row in range(len(board) - (k - 1)): # to ensure list index is not out of range
			if board[row][column] != 0:
				consectokens = 0
				for kadd in range(k):
					#checking if there a k consecutive pieces in a row
					if board[row][column] == board[row + kadd][column]:
						consectokens += 1

						if consectokens == k:
							return board[row][column]
	return False


def horizontal_win_k(board, k):
	"""
    Checks if the game has ended horizontally

    :param board: The game board, 2D list.
	:param k: the number of pieces to win
    :return: player number if win or false if no win
    """
	consectokens = 0
	piece = 0 
	for column in range(len(board[0]) - (k - 1)): # to ensure list index is not out of range
		for row in range(len(board)):
			if board[row][column] != 0:# looks for a player cell
				piece = board[row][column]
				consectokens = 0 
				for kadd in range(k):
					if piece == board[row][column + kadd]:
						consectokens += 1
						if consectokens == k:
							return board[row][column]
	return False


def pos_diagonal_win_k(board, k):
	"""
    Checks if the game has ended in a positive diagonal

    :param board: The game board, 2D list.
	:param k: the number of pieces to win
    :return: player number if win or false if no win
    """
	consectokens = 0
	for column in range(len(board[0]) - (k - 1)): #to check all board without going out of range
		for row in range(len(board) - (k - 1), len(board)):  
			if board[row][column] != 0:  # looks for a player cell 
				consectokens = 0
				for kadd in range(k):
					if board[row][column] == board[row - kadd][column + kadd]:
						consectokens += 1
						if consectokens == k:
							return board[row][column]
	return False


def neg_diagonal_win_k(board, k):
	"""
    Checks if the game has ended in a negative diagonal 

    :param board: The game board, 2D list.
	:param k: the number of pieces to win
    :return: player number if win or false if no win
    """
	consectokens = 0
	for column in range(len(board[0]) - (k - 1)): #to check all board without going out of range
		for row in range(len(board) - (k - 1)):  
			if board[row][column] != 0:# looks for a player cell
				consectokens = 0
				for kadd in range(k):
					if board[row][column] == board[row + kadd][column + kadd]:
						consectokens += 1
						if consectokens == k:
							return board[row][column]
	return False


def draw_k(board):
	"""
    Checks if the game board is full

    :param board: The game board, 2D list.
    :return: 0 if not full, -1 if full
    """
	for column in range(len(board[0])):
		if board[0][column] == 0:
			return 0

	return -1

def clear_screen():
	"""
	Clears the terminal for Windows and Linux/MacOS.

	:return: None
	"""
	import os
	os.system('cls' if os.name == 'nt' else 'clear')
	

def local_multi_player_game_k():
	"""
	Runs a local  player game of Connect 4.

	:return: None
	"""
	#input number of players and pieces to win 
	n = int(input("Enter number of players: "))  
	k = int(input("Enter number of pieces connected to win: "))

	
	#execute first turn
	clear_screen()
	board = create_board_k()
	
	#check k input is valid for the board dimensions
	while k >= len(board[0]) or k >= len(board):
		print('The number of pieces to win must be less than the one of the boards dimensions.')
		k = int(input("Enter number of pieces connected to win: "))

	#continue first turn
	print_board_k(board)
	player = 1
	col = execute_player_turn_k(player, board)
	print_board_k(board)

	#play the rest of the turns until end of game
	while end_of_game_k(board, k) == 0:
		print("Player", player,"dropped a piece into column", col)
		#swapping player turn 
		if player < n:
			player +=1
		else:
			player = 1
		col = execute_player_turn_k(player,board)
		print_board_k(board)

	#printing winning line
	for i in range(n):
		if end_of_game_k(board, k) == i+1:
			player_str = str(i+1)
			print('Player',player_str,'wins!')
			break
		elif end_of_game_k(board,k) == -1:
			print("It's a draw!")


def print_rules_k():
	"""
	Prints the rules of the game.

	:return: None
	"""
	print("================= Rules =================")
	print("Connect k is a multi-player game where the")
	print("objective is to get k number of your pieces")
	print("in a row either horizontally, vertically")
	print("or diagonally. The game is played on a")
	print("grid of your specified size. The first")
	print("player to get k pieces in a row wins the")
	print("game. If the grid is filled and no player")
	print("has won, the game is a draw.")
	print("=========================================")
	

def main_k():
	"""
	Defines the main application loop.
    User chooses a type of game to play or to exit.

	:return: None
	"""
	
	#printing options
	while True:	
		clear_screen()
		print("=============== Main Menu ===============")
		print("Welcome to Connect k!")
		print("1. View Rules")
		print("2. Play a local game against human players")
		print("3. Play a local game against cpu players")
		print("4. Play a local game against human and cpu players")
		print("5. Exit")
		print("=========================================")
		user_input = int(input())
		#directing options to their functions
		if user_input == 1:
			clear_screen()
			print_rules_k()
			input("Press Enter to Return to Main Menu")

		elif user_input == 2:
			local_multi_player_game_k()
			input("Press Enter to Return to Main Menu")
	
		elif user_input == 3:
			game_against_cpu_k()
			input("Press Enter to Return to Main Menu")

		elif user_input == 4:
			game_against_both_k()
			input("Press Enter to Return to Main Menu")
		else: 
			clear_screen()
			return


def cpu_player_easy_k(board, player):
    """
    Executes a move for the CPU on easy difficulty. This function 
    plays a randomly selected column.

    :param board: The game board, 2D list.
    :param player: The player whose turn it is (integer).
    :return: Column that the piece was dropped into, int.
    """
    random_num = random.randint(1,len(board[0])) #Selects a random number for the column
    column = int(random_num) #output it as integer
    while drop_piece_k(board,player,column) == False:  #repeatedly asking for input until a column that has space is selected
        random_num = random.randint(1,len(board[0]))
        column = int(random_num)
    return column

def valid_moves(board):
	'''
	checking which columns are valid for a drop piece, without user input
	param input: board 
	param return: list of column index (from 0) that piece can drop into
	'''
	n_cols = range(len(board[0])) # number of columns
	valid_moves = []
	for j in n_cols:
		if board[0][j] == 0:
			valid_moves.append(j) #create list of valid columns
	return valid_moves

def check_wins(board, player, k):
	'''
	checking if any moves will result in a win 
	param input: board, player (int), k (pieces to win)

	param output: column that would result in win. 
	if multiple columns would then the first one will be returned. 
	returns -1 if no win 
	'''
	
	cols = valid_moves(board)
	win_index = [0] * len(cols)

	#simulating a drop in all the columns
	for i in range(len(cols)):
		new_board = copy.deepcopy(board) #copy the current board
		drop_piece_k(new_board, player, cols[i]+1)
		#checking if dropping the piece means a win 
		if end_of_game_k(new_board, k)== player:
			win_index[i] = 1 #1 if move will result in win
		else:
			win_index[i] = 0 # 0 otherwise 
		new_board = []
	#setting the best column to play in as the one that causes a win 	
	if max(win_index)>0:
		best_move = cols[win_index.index(max(win_index))]
	else:
		best_move = -1 
	return best_move

def vertical_check_k(board,player,k):
	'''
	Inputs: (board, player, k) 
	returns a count for how many vertical ks there are on the board
	
	'''
	consectokens = 0
	count = 0
	
	#iterating through the board
	for row in range(len(board) - (k - 1)):
		for column in range(len(board[0])):
			#checking consecutive pieces for the player 
			if board[row][column] == player:
				consectokens = 0
				for kadd in range(k):
					if board[row][column] == board[row + kadd][column]:
						consectokens += 1

						if consectokens == k:
							count+=1

	return count

def horizontal_check_k(board,player,k):
	'''
	Inputs: (board, player, k) 
	returns a count for how many horizontal ks there are on the board
	
	'''
	consectokens = 0
	count = 0 
	#iterating through the board 
	for column in range(len(board[0]) - (k - 1)):
		for row in range(len(board)):
			#checking consecutive pieces for the player 
			if board[row][column] == player:
				consectokens = 0 
				for kadd in range(k):
					if board[row][column] == board[row][column + kadd]:
						consectokens += 1
						if consectokens == k:
							count+=1
	return count

def pos_diagonal_check_k(board,player, k):
	'''
	Inputs: (board, player, k) 
	returns a count for how many positive diagonal ks there are on the board
	
	'''
	consectokens = 0
	count = 0
	#iterating through the board
	for column in range(len(board[0]) - (k - 1)):
		for row in range(len(board) - (k - 1), len(board)):  
			#checking consecutive pieces for the player 
			if board[row][column] == player:  
				consectokens = 0
				for kadd in range(k):
					if board[row][column] == board[row - kadd][column + kadd]:
						consectokens += 1
						if consectokens == k:
							count+= 1
	return count 

def neg_diagonal_check_k(board, player, k):
	'''
	Inputs: (board, player, k) 
	returns a count for how many negative diagonal ks there are on the board
	
	'''
	consectokens = 0
	count= 0

	#iterating through the board
	for column in range(len(board[0]) - (k - 1)):
		for row in range(len(board) - (k - 1)):  
			#checking consecutive pieces for the player 
			if board[row][column] == player:
				consectokens = 0
				for kadd in range(k):
					if board[row][column] == board[row + kadd][column + kadd]:
						consectokens += 1
						if consectokens == k:
							count += 1
	return count

def check_clusters(board, player, k):
	'''
	checking if any moves will result in clusters. Being k-1 and k-2 pieces in a row 
	param input: board, player, k (pieces to win)

	param output: list of clusters per column 
	'''
	
	if k > 2: #making sure k-2 is not run if k is 2
		cols = valid_moves(board)
		n_k1 = [0] * len(cols)
		n_k2 = [0] * len(cols)
		score = [0] * len(cols)
		for i in range(len(cols)):
			new_board = copy.deepcopy(board) #copy the current board
			drop_piece_k(new_board, player, cols[i]+1)
			#checking if dropping the piece means multiple winning combinations
			n_k1[i] = vertical_check_k(new_board, player, k-1)+horizontal_check_k(new_board, player, k-1)+neg_diagonal_check_k(new_board, player, k-1)+pos_diagonal_check_k(new_board, player, k-1)
			n_k1[i] = n_k1[i]*3 #score 3x multiplier
			n_k2[i] = vertical_check_k(new_board, player, k-2)+horizontal_check_k(new_board, player, k-2)+neg_diagonal_check_k(new_board, player, k-2)+pos_diagonal_check_k(new_board, player, k-2)
			n_k2[i] = n_k2[i]*2 #2x multiplier 
			score[i] = n_k1[i] + n_k2[i]
		return score
	else:
		cols = valid_moves(board)
		n_k1 = [0] * len(cols)
		score = [0] * len(cols)
		for i in range(len(cols)):
			new_board = copy.deepcopy(board) #copy the current board
			drop_piece_k(new_board, player, cols[i]+1)
			#checking if dropping the piece means multiple winning combinations
			n_k1[i] = vertical_check_k(new_board, player, k-1)+horizontal_check_k(new_board, player, k-1)+neg_diagonal_check_k(new_board, player, k-1)+pos_diagonal_check_k(new_board, player, k-1)
			n_k1[i] = n_k1[i]*3 #score 3x multiplier 
			score[i] = n_k1[i]
		return score


def cpu_player_medium_k(board, player, k, n):
	"""
	Executes a move for the CPU on medium difficulty.
	It first checks for an immediate win and plays that move if possible. 
	If no immediate win is possible, it checks for an immediate win 
	for the opponent and blocks that move. If neither of these are 
	possible, it plays a random move.

	:param board: The game board, 2D list
	:param player: The player whose turn it is.
	:param k: number of pieces to win
	:param n: number of players 
	:return: Column that the piece was dropped into, int.
	"""

	#creating a list of opponent players 
	
	opp_players = []
	for i in range(n):
		if player != i+1:
			opp_players += [i+1]

	#getting the valid inputs from the board	
	valid_inputs = valid_moves(board)

	#checking moves that they may win with 
	their_wins = [0] * len(opp_players)
	for i in range(len(opp_players)):
		their_wins[i] = check_wins(board, opp_players[i], k)
		

	# first priority is checking we can win 
	if check_wins(board, player, k)>= 0:
		best_move = check_wins(board, player, k) 
		
	# second is blocking their potential win 
	elif max(their_wins)>=0:
		best_move = max(their_wins)
	
	#place randomly 
	else:
		best_move = valid_inputs[random.randint(0,len(valid_inputs)-1)]

	column = best_move + 1 #changing index back to 1
	
	#drop the piece 
	drop_piece_k(board,player,column)

	return column


def cpu_player_hard_k(board, player, k, n):
	"""
	Executes a move for the CPU on hard difficulty.
	This function creates a copy of the board to simulate moves.
    
	The function will place our winning piece as a priority, before blocking opponents winning pieces
	after that it searches for places with could result in winning combinations:
	places with k-1 pieces in a row or k-2 pieces in a row. It will place our piece in one of those places 
	before blocking the opponents clusters. It will place in the centre if there are none of these places available or if 
	there are equal oppurtunities for us as the opponents. It will play randomly otherwise

	:param board: The game board, 2D list.
	:param player: The player whose turn it is.
	:param n: number of players 
	:param k: number of pieces to win
	:return: Column that the piece was dropped into, int.
	"""
	
	# making opponent list 
	opp_players = []
	for i in range(n):
		if player != i+1:
			opp_players += [i+1]

	
	best_move = -1 # initialising best move
	
	#gathering valid inputs 
	valid_inputs = valid_moves(board)

	#calculate their wins 
	their_wins = [0] * len(opp_players)
	for i in range(len(opp_players)):
		their_wins[i] = check_wins(board, opp_players[i], k)

	#calculate their check_clusters
	their_clusters = [[0] * len(valid_inputs) for i in range(len(opp_players))]
	for i in range(len(opp_players)):
		their_clusters[i] = check_clusters(board,opp_players[i],k)
	
	#getting max cluster position and value
	max_their_clusters = max(their_clusters[0])
	index_their_clusters = valid_inputs[their_clusters[0].index(max_their_clusters)]
	#their clusters is 2D so must iterate to find the highest value position to play
	for i in range(1,len(their_clusters)):
		if max(their_clusters[i]) > max_their_clusters:
			max_their_clusters = max(their_clusters[i])
			index_their_clusters = valid_inputs[their_clusters[i].index(max_their_clusters)]
	
	
	#finding our clusters 
	our_clusters = check_clusters(board,player,k)
		
	# first priority is checking we can win 
	if check_wins(board, player, k)>= 0:
		best_move = check_wins(board, player, k) 
		
	# second is blocking their potential win 
	elif max(their_wins)>=0:
		best_move = max(their_wins)

	# third is playing a move that will provide the most oppurtunities to win  
	elif max(our_clusters)> max_their_clusters and max(our_clusters)>0:
		best_move = valid_inputs[our_clusters.index(max(aggregate))]

	# fourth is playing a move that will block their potential
	elif max_their_clusters > max(our_clusters) and max_their_clusters>0:
		best_move = index_their_clusters
					

	# fifth is playing in the centre 
	elif valid_inputs.count(len(board[0])//2) == 1: #+1 to get middle and -1 to get correct index 
		best_move = len(board[0])//2
	
	# sixth is playing random
	else:
		best_move = valid_inputs[random.randint(0,len(valid_inputs)-1)]

	column = best_move + 1 #changing index back to 1
	
	drop_piece_k(board,player,column)

	return column


def game_against_cpu_k():
	"""
	Runs a game of Connect k against computers.

	:return: None
	"""
	n = int(input("Enter the number of cpu players to play against: "))

	user_choice = [0] * n
	print("You are player 1.")
	for i in range(n):
		print("Please Select A Difficulty Level for player",i+2)
		print("1. Easy")
		print("2. Medium")
		print("3. Hard")
		print("=================================")	
		user_choice[i] = int(input())

	k = int(input("Enter number of pieces connected to win: "))

	clear_screen()
	board = create_board_k()

	#validating k input with board size 
	while k >= len(board[0]) or k >= len(board):
		print('The number of pieces to win must be less than the one of the boards dimensions.')
		k = int(input("Enter number of pieces connected to win: "))

	print_board_k(board)
	player = 1
	column = execute_player_turn_k(player,board) #the first turn/play occurs
	print_board_k(board)
	print("Player", player,"dropped a piece into column", column)
	
	while end_of_game_k(board,k) == 0: #iterating until game has ended 
		
		#swapping player turn 
		if player < n+1: # n is not total players in this case its only no of cpus
			player +=1	
			print("Computer", player, "Turn")
			time.sleep(1.6)
			if user_choice[player-2] == 1:
				column = cpu_player_easy_k(board, player) #run cpu easy strat; & get available column value
			elif user_choice[player-2] == 2:
				column = cpu_player_medium_k(board, player, k, n+1) #run cpu medium strat; & get the available column value
			else:
				column = cpu_player_hard_k(board, player, k, n+1) #run cpu hard strat; & get the available column value
			print_board_k(board)	
			print("Computer dropped a piece into column", column)
			time.sleep(1.6)
		else:
			player = 1 #going back to player 1
			column = execute_player_turn_k(player,board) #executing turn for the next player
			print_board_k(board)
			print("Player 1 dropped a piece into column", column)
			time.sleep(1)

	# printing outcome of the game 
	for i in range(n+1):
		if end_of_game_k(board, k) == i+1:
			player_str = str(i+1)
			print('Player',player_str,'wins!')
			break
		elif end_of_game_k(board,k) == -1:
			print("It's a draw!")

def game_against_both_k():
	"""
	Runs a game of Connect k against the computer and human players.

	:return: None
	"""
	n_human = int(input("Enter the number of human players: "))
	n_cpu = int(input("Enter the number of cpu players: "))

	user_choice = [0] * n_cpu
	print("Humans are players 1 to", n_human)
	for i in range(n_cpu):
		print("Please Select A Difficulty Level for player",n_human+i+1)
		print("1. Easy")
		print("2. Medium")
		print("3. Hard")
		print("=================================")	
		user_choice[i] = int(input())

	k = int(input("Enter number of pieces connected to win: "))

	clear_screen()
	board = create_board_k()

	#validating k input 
	while k >= len(board[0]) or k >= len(board):
		print('The number of pieces to win must be less than the one of the boards dimensions.')
		k = int(input("Enter number of pieces connected to win: "))

	print_board_k(board)
	player = 1
	column = execute_player_turn_k(player,board) #the first turn/play occurs
	print_board_k(board)
	print("Player", player,"dropped a piece into column", column)
	
	while end_of_game_k(board,k) == 0: #iterating until game has ended 
		#swapping player turn 
		
		if player < n_human:
			player +=1	
			#running human turn 
			print("Human", player, "Turn")
			col = execute_player_turn_k(player,board)
			print_board_k(board)
			print("Player", player,"dropped a piece into column", col)
		elif n_human <= player and player < n_human+n_cpu:
			player += 1
			#running cpu turn 
			if user_choice[player-n_human-1] == 1:
				column = cpu_player_easy_k(board, player) #run cpu easy strat; & get available column value
			elif user_choice[player-n_human-1] == 2:
				column = cpu_player_medium_k(board, player, k, n_human+n_cpu) #run cpu medium strat; & get the available column value
			else:
				column = cpu_player_hard_k(board, player, k, n_human + n_cpu) #run cpu hard strat; & get the available column value
			print_board_k(board)	
			print("Computer", player-n_human, "dropped a piece into column", column)
			time.sleep(1.6)
		else:
			player = 1
			column = execute_player_turn_k(player,board) #executing turn for the next player
			print_board_k(board)
			print("Player 1 dropped a piece into column", column)
			time.sleep(1)

	# printing outcome of the game 
	for i in range(n_human+n_cpu):
		if end_of_game_k(board, k) == i+1:
			player_str = str(i+1)
			print('Player',player_str,'wins!')
			break
		elif end_of_game_k(board,k) == -1:
			print("It's a draw!")
		

main_k()
	


