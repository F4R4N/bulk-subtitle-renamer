import os, re

import argparse
# src_dir = input("enter your source directory exact path : ")
# name = input("enter series name : ")
# season = int(input("enter season : "))
# quality = input("enter movie quality .etc(720p, 480p) : ")
# file_format = input("enter movie file format .etc(mkv, mp4) : ")

def main():
	parser = argparse.ArgumentParser()
	parser.add_argument('-p', '--path', required=True, help='path that the series and subtitle files are in it e.g /home/faran/Videos/myseries')
	parser.add_argument('-n', '--name', required=True, help='name for the series new name.')
	parser.add_argument('-s', '--season', required=True, help='season number.')
	parser.add_argument('-q', '--quality', required=False, help='(optional) add series quality name e.g 720p, 480p')
	parser.add_argument('-e', '--extention', required=True, help='your video extention.Note :videos recognize by this arguement be carefull.')
	parser.add_argument('-h', '--help', action='help', default=argparse.SUPPRESS, help='Show this help message and exit.')

	args = parser.parse_args()
    if 
def rename():
	format_matched_mov = []
	format_matched_sub = []
	dic_of_eps = {}
	os.chdir(src_dir)
	ls = os.listdir()
	# find the format that matched user format (movie)
	for mov_format in ls:
	    matched_with_user_format_mov = re.findall(rf'.*' + re.escape(file_format), mov_format)
	    format_matched_mov.append(matched_with_user_format_mov)
    # find the formats that match srt (subtitle)
	for sub_format in ls:
		matched_with_user_format_sub = re.findall(rf'.*' + "srt", sub_format)
		format_matched_sub.append(matched_with_user_format_sub)

	format_matched_mov = [x for x in format_matched_mov if x != []]
	format_matched_sub = [x for x in format_matched_sub if x != []]

    # find episode number (movie)
	for episode_mov in format_matched_mov:
	    matched_with_episode_num_mov = re.findall(rf'\d+', episode_mov[0])[1]
	    print("mov : ", matched_with_episode_num_mov)
	    full_name_mov = name + '-' + str(season) + '-' + matched_with_episode_num_mov + '-' + quality + '.' + file_format
	    os.rename(episode_mov[0], full_name_mov)
    
    # find episode number (subtitle)
	for episode_sub in format_matched_sub:
		matched_with_episode_num_sub = re.findall(rf'\d+', episode_sub[0])[1]
		print("sub : ", matched_with_episode_num_sub)
		full_name_sub = name + '-' + str(season) + '-' + matched_with_episode_num_sub + '-' + quality + '.' + 'srt'
		os.rename(episode_sub[0], full_name_sub)

if __name__ == "__main__":
	main()
