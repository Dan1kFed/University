library(psych)
library(ggplot2)
frame <- read.csv("~/Документы/Универ/Прога/Проект R/AppleStore.csv")
head(frame)
View(frame)
str(frame)
names(frame)

summary(frame)
 
sum(is.na(frame))
 
#Тест выборок
frame$prime_genre == 'Games' 
frame[frame$prime_genre == 'Games', 9]

#Матстат
mean_paid_genre <- aggregate(x = frame$price, by = list(frame$prime_genre), FUN = mean)
colnames(mean_paid_genre) <- c("Genre", "Mean_price") 

discr <- describeBy(x = frame[,-c(1,2,3,4,5,11,12,13)], group = list(frame$prime_genre), mat = T, digits = 3) #Опистаельная статистика для всего датафрейма, кроме факторных столбов


#Графики
boxplot(price ~ prime_genre, frame)

ggplot(frame, aes(x = price))+
  geom_histogram(fill = "blue", col = "black", binwidth = 10)

ggplot(frame, aes(x = user_rating, fill = cont_rating))+
  geom_density(alpha = 0.3)

ggplot(frame, aes(x = user_rating, y = prime_genre, col = cont_rating))+
  geom_point(size = 5)



#Оценка датасета
table1 <- table(Cont = frame$cont_rating, Genre = frame$prime_genre)
table1
prop.table(table1)#общий процент скачиваний по жанрам
mosaicplot(table1)

#кореляционаая матрица






