import React, { Component } from 'react';
import { NavigationTabScreenOptions } from 'react-navigation';
import { View, Text } from 'react-native';
import { TabNavigationOptionsFactory } from '../layout/tab-navigation-options-factory';
import styles from '../layout/styles';

const navOptionsFactory = new TabNavigationOptionsFactory();

export class FeedScreen extends Component {

    public static navigationOptions: NavigationTabScreenOptions =
    navOptionsFactory.create('Feeds', 'ios-pulse', 'ios-pulse-outline');

    public render() {
        return <View style={styles.container}>
            <Text>Feed</Text>
        </View>;
    }
}